function writeText(message) {
    document.getElementById("response").innerText = message;
}

function respondToUser() {

    let enteredNumber = document.getElementById("yourAge").value;
    let theValueEnteredIsAnumber = enteredNumber == parseInt(enteredNumber);
    let response = "";
    if (theValueEnteredIsAnumber == true) {
        if (enteredNumber >= 30) {
            response = "You are really old"
        } else {
            response = "You are still young"
        }
    } else {
        response = "The value entered is not a number"
    }
    writeText(response)
}
document.getElementById("okButton").addEventListener("click", respondToUser);