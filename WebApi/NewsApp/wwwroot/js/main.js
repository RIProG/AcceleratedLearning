console.log("Moi Mukulat!");
let newsList = document.getElementById("newsList").innerText;
let newsTable = document.getElementById("newsTable");
let addArea = document.getElementById("addArea");
let updateArea = document.getElementById("updateArea");

async function clickSeed() {
    nrOfNews.innerText = ``;
    newsTable.innerHTML = ``;
    updateArea.innerHTML = ``;
    addArea.innerHTML = ``;

    let response = await fetch(`api/news/seed`, {
        method: "POST"
    });

    if (response.status === 204) {
        console.log("Seed done!");
        addArea.innerHTML = `Seed done!`
    }
    else {
        console.error("Unexpected error", response);
    }
}

async function clickShowAllNews() {
    nrOfNews.innerText = ``;
    updateArea.innerHTML = ``;
    addArea.innerHTML = ``;
    newsTable.innerHTML = `<tr><th>ID</th><th>Header</th><th>Intro</th></tr>`
    let response = await fetch(`api/news/`, {
        method: "GET"
    });

    if (response.status === 200) {
        let result = await response.json();
        console.log(result);
        newsTable.innerHTML = `<tr><th>ID</th><th>Header</th><th>Intro</th></tr>`;

        for (let i = 0; i < result.length; i++) {
            let newRow = newsTable.insertRow(newsTable.rows.length);
            let newCell1 = newRow.insertCell(0);
            let newCell2 = newRow.insertCell((1));
            let newCell3 = newRow.insertCell((2));
            let obj = result[i];
            newCell1.innerText = obj.id;
            newCell2.innerText = obj.header;
            newCell3.innerText = obj.intro;
        }

    }
    else {
        console.error("Unexpected error", response);
    }
}

async function clickRevealAddNews() {
    nrOfNews.innerText = ``;
    newsTable.innerHTML = ``;
    updateArea.innerHTML = ``;
    addArea.innerHTML = `<h3>Add news</h3>

    Header: <input id="addAreaHeader" type="text" />
    Category: <select id="addAreaCategory"></select>
    Intro: <input id="addAreaIntro" type="text" />
    Body: <input id="addAreaBody" type="text" />
        <button onclick="clickAddNews()">Add</button>`;
}

async function clickAddNews() {
    let addHeader = document.getElementById("addAreaHeader").value;
    let addIntro = document.getElementById("addAreaIntro").value;
    let addBody = document.getElementById("addAreaBody").value;

    let response = await fetch("api/News", {
        method: "POST",
        body: JSON.stringify(
            {
                header: addHeader,
                intro: addIntro,
                body: addBody,
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });
    addArea.innerHTML = `News added`;
}

async function clickRevealUpdateNews() {
    nrOfNews.innerText = ``;
    newsTable.innerHTML = ``
    addArea.innerHTML = ``;
    updateArea.innerHTML = `<h3>Update</h3>
            Id: <input id="updateAreaId" type="text" />
            Header: <input id="updateAreaHeader" type="text" />
            Category: <select id="updateAreaCategory"></select>
            Intro: <input id="updateAreaIntro" type="text" />
            Body: <input id="updateAreaBody" type="text" />
            <button onclick="clickUpdateNews()">Update</button>
            <div id="updateAreaError"></div> `;
}

async function clickUpdateNews() {
    let updateAreaId = document.getElementById("updateAreaId").value;
    let updateAreaHeader = document.getElementById("updateAreaHeader").value;
    let updateAreaCategory = document.getElementById("updateAreaCategory").value;
    let updateAreaIntro = document.getElementById("updateAreaIntro").value;
    let updateAreaBody = document.getElementById("updateAreaBody").value;

    let response = await fetch("api/News/", {
        method: "PUT",
        body: JSON.stringify(
            {
                Id: updateAreaId,
                Header: updateAreaHeader,
                Category: updateAreaCategory,
                Intro: updateAreaIntro,
                Body: updateAreaBody,
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    console.log(response.status);
    updateArea.innerHTML = `News updated`;
}

async function clickRecreate() {
    nrOfNews.innerText = ``;
    newsTable.innerHTML = ``
    addArea.innerHTML = ``;
    updateArea.innerHTML = ``;
    let response = await fetch(`api/news/recreate`, {
        method: "POST"
    });

    if (response.status === 204) {
        console.log("Recreation done!");
    }
    else {
        console.error("Unexpected error", response);
    }

    addArea.innerHTML = `Database recreated`;

}
async function clickStatArea() {
    newsTable.innerHTML = ``
    addArea.innerHTML = ``;
    updateArea.innerHTML = ``;
    let response = await fetch(`api/news/count`, {
        method: "GET"
    });

    if (response.status === 200) {
        let result = await response.json();
        let nrOfNews = document.getElementById("nrOfNews");
        console.log(result);
        nrOfNews.innerText = `Number of news: ${result}`;
    }

}


