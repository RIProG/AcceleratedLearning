let playerTurn = document.getElementById('playerTurn');
let markers = document.getElementsByClassName('marker');
let containers = document.getElementsByClassName('holder');
let activeMarker;
let holderArray = ["cross", "cross", "cross", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "circle", "circle", "circle"];
playerTurn.innerText = "It's cross-players turn!"

for (let marker of markers) {
    marker.addEventListener('dragstart', (e) => {
        e.srcElement.className = "held";
        activeMarker = e.srcElement;
    });
    marker.addEventListener('dragend', (e) => {
        e.srcElement.className = "marker"
    });
}

for (let container of containers) {

    container.addEventListener("mousedown", (e) => {
        holderArray[container.id] = "empty";
    })

    container.addEventListener("dragover", (e) => {
        let tempId = e.srcElement.id;
        if (holderArray[tempId] == "empty" && tempId >= 0) {
            e.preventDefault();
        }
    });

    container.addEventListener("dragenter", (e) => {
        let tempId = e.srcElement.id;
        if (holderArray[tempId] == "empty" && tempId >= 0) {
            e.preventDefault();
        }
    });

    container.addEventListener("dragleave", (e) => {
    });

    container.addEventListener("drop", (e) => {
        e.srcElement.className = "holder";
        if (holderArray[e.srcElement.id] == "empty") {
            e.srcElement.append(activeMarker);
            holderArray[e.srcElement.id] = activeMarker.id;
            if ((holderArray[3] == holderArray[4] && holderArray[4] == holderArray[5] && holderArray[3] != "empty")
                || (holderArray[6] == holderArray[7] && holderArray[7] == holderArray[8] && holderArray[6] != "empty")
                || (holderArray[9] == holderArray[10] && holderArray[10] == holderArray[11] && holderArray[9] != "empty")
                || (holderArray[3] == holderArray[6] && holderArray[6] == holderArray[9] && holderArray[3] != "empty")
                || (holderArray[4] == holderArray[7] && holderArray[7] == holderArray[10] && holderArray[4] != "empty")
                || (holderArray[5] == holderArray[8] && holderArray[8] == holderArray[11] && holderArray[5] != "empty")
                || (holderArray[3] == holderArray[7] && holderArray[7] == holderArray[11] && holderArray[3] != "empty")
                || (holderArray[5] == holderArray[7] && holderArray[7] == holderArray[9] && holderArray[5] != "empty")) {
                alert(`${activeMarker.id.toUpperCase()} WINS!`);
                console.log("alert?");
                //sleep();
                location.reload();
            }
            console.log(holderArray)
            let markerText = "cross";
            if (activeMarker.id == "cross") {
                markerText = "circle";
            }
            
            playerTurn.innerText = `It's ${markerText}-players turn!`
        }

    });

    //function sleep() {
    //    let start = new Date().getTime();

    //    for (let i = 0; i < 1e7; i++) {

    //        if ((new Date().getTime() - start) > 10000) {
    //            break;
    //        }

    //    }
    //}


}