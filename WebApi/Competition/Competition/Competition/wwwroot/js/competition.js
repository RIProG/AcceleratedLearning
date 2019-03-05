let submitButton = document.getElementById("submitButton");
let textFieldArea = document.getElementById("textFieldArea");
let numberRows = document.getElementById("numberRows");
let numberGroups = document.getElementById("numberGroups");

function AddGroups(rows, groups) {
    let numberOfRows = rows.value;
    let numberOfGroups = groups.value;

    //INTE FÄRDIGT
    for (let groupNumber of numberOfGroups) {

    for (let rowNumber of numberOfRows) {
        let textarea = document.createElement("input");
        textFieldArea.appendChild(textarea);
    }

    }
}