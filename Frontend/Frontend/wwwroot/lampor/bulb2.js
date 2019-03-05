let buttons = document.getElementById("buttons");
let bulbs = ["bulb 1", "bulb 2", "bulb 3"];
let bulbSpace = document.getElementById("bulbSpace");

for (const bulbLabel of bulbs) {
    let bulb = document.createElement("img")
    bulbSpace.appendChild(bulb);
    bulb.src = "bulb-off.jpg";
    let button = document.createElement("button");
    button.innerText = "Light " + bulbLabel;
    button.addEventListener("click", () => switchOn(bulb));
    buttons.appendChild(button);
};

function switchOn(bulb) {
    bulb.src = "bulb-on.jpg"
}
