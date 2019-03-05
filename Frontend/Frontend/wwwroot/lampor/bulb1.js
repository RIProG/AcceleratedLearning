let lampButton = document.getElementById("lampButton");
let bulbSpace = document.getElementById("bulbSpace");
let bulb = document.getElementById("bulb")

lampButton.addEventListener("click", switchOn)

function switchOn(){
    bulb.src = "bulb-on.jpg";
    
}
