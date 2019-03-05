let button1 = document.getElementById("button1");
let button2 = document.getElementById("button2");
let button3 = document.getElementById("button3");
let cat = document.getElementById("katt");
let sometext = document.getElementById("sometext");
cat.style.display = "none";
let textruta = document.getElementById("textruta");

function showCat() {
    if (cat.style.display == "none") {
        cat.style.display = "block";
    }
}

button1.addEventListener("click", showCat);

button2.addEventListener("click", () => {
    sometext.innerHTML = sometext.innerHTML + '<br>Halloj!';
});

button3.addEventListener("click", () => {
    let textAttSkriva = textruta.value;

    if (textAttSkriva == "")
        alert("Skriv nåt i textrutan")

    else
        sometext.innerHTML = sometext.innerHTML + "<br>" + textAttSkriva;
});