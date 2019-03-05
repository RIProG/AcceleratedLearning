function alertButton() {
    alert('You clicked!')
}

let button2 = document.getElementById("button2");
let button3 = document.getElementById("button3");
let button4 = document.getElementById("button4");
let button5 = document.getElementById("button5");

button2.addEventListener("click", alertButton);

button3.addEventListener("click", () => {
    console.log(`Hello Tobias what's happening?!`);
    console.log(`Im gonna need you to go ahead and come in tomorrow yo!`);
});


button4.addEventListener("click", () => {
    document.getElementById("rubrik").innerHTML = "Ny rubrik"
});

button5.addEventListener("click", () => {
    document.getElementById("button5").style.color = 'Red'});

let testy = () => alert('teeeeest!') //Skapar en funktion som kan kallas med testy()

let hello = () => {
    document.getElementById("ingress").innerHTML = "Bom Dia!"
}
//Alternativ ingress.innerHTML/innerText = "Bom Dia!" (InnerText tolkar det bokstavligt, HTML med taggar)

hello();



//function writeInConsole() {
//    console.log("Nu skriver jag i console");
//}