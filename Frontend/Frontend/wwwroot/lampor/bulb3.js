let bulbs = ["bulb 1", "bulb 2", "bulb 3"];
let bulbSpace = document.getElementById("bulbSpace");
let button = document.getElementById("button");

for (const bulbLabel of bulbs) {
    let bulb = document.createElement("img")
    bulbSpace.appendChild(bulb);
    bulb.src = "bulb-off.jpg";
    button.addEventListener("click", () => switchOn(bulb));
};


function switchOn(bulb) {
    bulb.src = "bulb-on.jpg"
}
