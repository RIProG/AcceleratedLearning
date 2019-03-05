let redButton = document.getElementById("redButton");
let greenButton = document.getElementById("greenButton");
let blueButton = document.getElementById("blueButton");
let box = document.getElementById("box");

blueButton.addEventListener("click", () => {
    box.style.backgroundColor = 'blue';
});

redButton.addEventListener("click", () => {
    box.style.backgroundColor = 'red';
});

greenButton.addEventListener("click", () => {
    box.style.backgroundColor = 'green';
});
