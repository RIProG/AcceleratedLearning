let minText = document.getElementById("minText");
let minKnapp = document.getElementById("minKnapp");
let resultat = document.getElementById("resultat");
minKnapp.addEventListener("click",
    () => {
        let maxValue = parseInt(minText.value);
        let numlist = [];
        for (let i = 1; i <= maxValue; i++)
            numlist.push(i);
        resultat.innerText = numlist.join(", ");
    });