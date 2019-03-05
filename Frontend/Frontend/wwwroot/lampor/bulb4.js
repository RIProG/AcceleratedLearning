let bulbs = ["bulb 1", "bulb 2", "bulb 3", "bulb4", "bulb5"];
let bulbSpace = document.getElementById("bulbSpace");
let bulbSpaceArray = [];
let button = document.getElementById("button");
let textSpace = document.getElementById("textSpace");
let i = 0;

for (const bulbLabel of bulbs) {
    let bulb = document.createElement("img");
    bulbSpace.appendChild(bulb);
    bulbSpaceArray.push(bulb);
    bulb.src = "bulb-off.jpg";
}

button.addEventListener("click", switchBulb);

function switchBulb() {
    for (var bulb of bulbSpaceArray) {
        if (bulb === bulbSpaceArray[i]) {
            bulb.src = "bulb-on.jpg";
        }

        else
            bulb.src = "bulb-off.jpg";
    }
    i++;

    textSpace.innerText = `Current bulb: ${i}`;
    if (i >= 5) {
        i = 0
    }
}
