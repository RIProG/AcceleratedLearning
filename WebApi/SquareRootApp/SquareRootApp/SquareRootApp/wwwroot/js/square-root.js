
async function squareRoot() {
    let number = document.getElementById("number");

    let resultDiv = document.getElementById("result");
    let errorDiv = document.getElementById("error");
    resultDiv.innerText = "";
    errorDiv.innerText = "";

    let response = await fetch(`api/squareroot?number=${number.value}`);

    if (response.status === 200) {
        let result = await response.json();
        resultDiv.innerText = `Du angav ${number.value}, roten ur ${number.value} är ${result}`;
    }
    else {
        let result = await response.text();
        errorDiv.innerText = result;
    }
}

