let previousButton = document.getElementById("previousButton");
let nextButton = document.getElementById("nextButton");
let box = document.getElementById("box");
let color = 220;

previousButton.addEventListener("click", () => {
    color = color - 5;
    box.style.backgroundColor = `rgb(${color},0,0)`;
});

nextButton.addEventListener("click", () => {
    color = color + 5;
    box.style.backgroundColor = `rgb(${color},0,0)`;
});