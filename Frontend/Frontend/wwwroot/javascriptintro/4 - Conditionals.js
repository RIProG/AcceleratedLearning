//cond1();
//cond2();
//cond3();
//cond4();
//cond5();
//cond6();
//cond7();
//cond8();
cond9();

function cond1() {

    /*
	    Skapa en variabel shoeMaria och sätt till 36
	    Skapa en variabel shoeAli och sätt till 42
	    Skriv en if-sats som kollar om de har samma skostorlek (skriv ut olika texter)
	    Experimentera med att ändra värden på "shoeMaria" och "shoeAli"
    */
    let shoeMaria = 36;
    let shoeAli = 42;
    if (shoeMaria == shoeAli) {
        console.log('Maria och Ali har samma skostorlek!');
    }
    else {
        console.log('Maria och Ali har inte samma skostorlek...');
    }

}

function cond2() {

    /*
	    Kolla om Ali har större skostolek än Maria
	    Skriv ut lämpligt meddelande
    */
    let shoeMaria = 36;
    let shoeAli = 42;
    if (shoeAli > shoeMaria) {
        console.log('Ali har större skostorlek än Maria!');
    }
    else {
        console.log('Ali har inte större skostorlek än Maria...');
    }

}

function cond3() {

    /*
	    Samma som sist, men kolla även om de har samma skostorlek
    */
    let shoeMaria = 36;
    let shoeAli = 42;
    if (shoeAli > shoeMaria) {
        console.log('Ali har större skostorlek än Maria!');
    }
    else if (shoeAli == shoeMaria) {
        console.log('Ali och Maria har samma skostorlek!');
    }

}

function cond4() {

    /*
	    Lägg till en till variabel "bigFoot" med skostorlek 52
	    Skriv en if-sats som kolla om bigFoot har större skostorlek än både Ali och Maria
    */
    let shoeMaria = 36;
    let shoeAli = 42;
    let bigFoot = 52;

    if (bigFoot > shoeMaria && bigFoot > shoeAli) {
        console.log('BigFoot har större skostorlek än både Maria och Ali.');
    }

}

function cond5() {

    /*
	    Skriv en ifsats som kollar om någon av de tre har en skostorlek som är större än 50
    */
    let shoeMaria = 36;
    let shoeAli = 42;
    let bigFoot = 52;

    if (bigFoot > 50 || shoeAli > 50 || shoeMaria > 50) {
        console.log('Någon har större skostorlek än 50.');
    }

}

function cond6() {

    /*
	    Skapa en variabel "favoriteVegetable" och sätt den till "kålrot"
	    Använd en switch-sats för att kolla värdet på "favoriteVegetable" och svara på olika sätt
	    Om t.ex värdet av "favoriteVegetable" är "majrova" skriv "Passar till falafel"
    */
    let favoriteVegetable = "majrova";
    switch (favoriteVegetable) {

        case 'majrova': console.log("Passar till falafel")
            break;
        case 'kålrot': console.log("Ok, inte supergött men ändå...")
            break;

        default:
    }
}

function cond7() {

    /*
	    Samma som sist men skapa först en variabel "answer"
	    Istället för att använda "console.log" inuti switch-satsen så sätt variabel "answer"
	    Använd tillslut "console.log" för att skriva ut värdet av "answer"
    */
    let answer;
    let favoriteVegetable = "kålrot";
    switch (favoriteVegetable) {

        case 'majrova': answer = "Passar till falafel"
            console.log(answer)
            break;
        case 'kålrot': answer = "Ok, inte supergött men ändå..."
            console.log(answer)
            break;

        default:
    }
}

function cond8() {


    /*
	    Jämför == och === i en ifsats
	    Testa med en ifsats om 3=="3" är sant
	    Testa med en ifsats om 3==="3" är sant
    */
    if (3==3) {
        console.log('True');
    }
    if (3===3) {
        console.log('True');
    }
}

function cond9() {

    /*
	    Övning i "ternary operator"
	    Skapa en variabel a och sätt den till 13*13
	    Skapa en variabel b och sätt den till 169
	    Använd "ternary operator" för att kolla om de är lika. Lägg svaret (strängen "lika" eller "olika") i en variabel "result"
	    Skriv ut result
    */
    let result;
    let a = 13 * 13;
    let b = 169;
    a = b ? result = "Lika" : result = "Olika";
    console.log(result);
  
}