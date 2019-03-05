let rubrik = document.getElementById("rubrik");
let button1 = document.getElementById("button1");
let button2 = document.getElementById("button2");
let button3 = document.getElementById("button3");


let writeInGreen = false;
let padding = 10;

function writeGreen() {
    writeInGreen = !writeInGreen;

    if (writeInGreen) {
        rubrik.style.color = 'green';
    }
    else 
        rubrik.style.color = 'black';

}

button1.addEventListener("click", writeGreen);

function changeSize() {
    padding += 10;
    button2.style.padding = `${padding}px`;

}

button2.addEventListener("click", changeSize)

button3.addEventListener("mouseover", () => {
    button3.style.color = "green";
})

button3.addEventListener("mouseout", () => {
    button3.style.color = "black";
})