let button = document.getElementById("button");
let box = document.getElementById("box");

function switchColor(){
    if (box.style.backgroundColor == 'red') {
        box.style.backgroundColor = 'green';
    }
    else if (box.style.backgroundColor == 'green') {
        box.style.backgroundColor = 'blue';
    }
    else {
        box.style.backgroundColor = 'red';
    }
}
button.addEventListener("click", switchColor);