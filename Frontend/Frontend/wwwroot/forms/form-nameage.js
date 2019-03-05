function writeText(message) {
    document.getElementById("response").innerText = message;
}

function respondToUser() {
    let yourAge = document.getElementById("yourAge").value;
    let yourName = document.getElementById("yourName").value;
    let response = "";
    if (yourAge == 32 && yourName == "Rikard") {
        response = "I like you!"
    } else {
        response = `You are ${yourAge} years old and your name is ${yourName}`
    }
    document.getElementById("response").innerHTML = response;
    writeText(response)
}

document.getElementById("okButton").addEventListener("click", respondToUser)
