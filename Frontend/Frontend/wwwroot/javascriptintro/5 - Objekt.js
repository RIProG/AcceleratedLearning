//obj1();
//obj2();
//obj3();
//obj4();
objExtra1();

function obj1() {
    
    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */
    let person = { firstName: "Johan", lastName: "Rheborg", birthYear: 1963 };
    console.log(person.firstName);
    console.log(person.firstName + person.lastName);

}

function obj2() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)
       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */
    let person = {
        firstName: "Johan", lastName: "Rheborg", birthYear: 1963, role1: "Percy Nilegård", role2: "Farbror Barbro",
        street: "Kammakargatan 38 lgh 1401", city: "Stockholm", country: "Sweden"
    };
    console.log(`${person.firstName} är född ${person.birthYear}`);
    console.log(`${person.firstName} bort på gatan ${person.street}`);
    console.log(`${person.firstName} har spelat 3 roller, bland annat ${person.role1}`);

}


function obj3() {

    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns XXXst målningar"
       Skriv ut den tredje målningen t.ex: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */
    let paintings = ["Mona-Lisa", "Stjärnenatt", "Guernica"];
    paintings[0] = { Name: "Mona-Lisa", Artist: "Leonardo da Vinci", Year: "1507" };
    paintings[1] = { Name: "Stjärnenatt", Artist: "Vincent van Gogh", Year: "1889" };
    paintings[2] = { Name: "Guernica", Artist: "Pablo Picasso", Year: "1937" };

    console.log(`Det finns ${paintings.length}st målningar`);
    console.log(`${paintings[2].Artist} målade ${paintings[2].Name} år ${paintings[2].Year}`);
    for (x of paintings){
        console.log(x.Name.padEnd(20) + x.Year.padEnd(20) + x.Artist);
    }
 
}

function obj4() {

    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i paintingsarrayen mha "push".
       Skriv ut dess år mha variablen "paintings" 
       Använd "pop" för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */
    let paintings = ["Mona-Lisa", "Stjärnenatt", "Guernica"];
    paintings[0] = { Name: "Mona-Lisa", Artist: "Leonardo da Vinci", Year: "1507" };
    paintings[1] = { Name: "Stjärnenatt", Artist: "Vincent van Gogh", Year: "1889" };
    paintings[2] = { Name: "Guernica", Artist: "Pablo Picasso", Year: "1937" };

    let skriet = { Name: "Skriet", Artist: "Edvard Munch", Year: "1893" };
    paintings.push(skriet);
    console.log(paintings[3].Year);
    paintings.pop();
    paintings.pop();
    paintings.pop();
    console.log(`Antal målningar: ${paintings.length}`);

  
}

// -------- EXTRA UPPGIFTER -----------------------------------------

function objExtra1() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till en metod "fullName" till person
       Lägg till en metod "numberOfRoles" till person

       Används sedan dessa för att skriva ut:
            Johan Rheborg
            Johan Rheborg har spelat i 3 roller
    */
    let person = {
        firstName: "Johan", lastName: "Rheborg", birthYear: 1963, roles: ["Percy Nilegård", "Farbror Barbro"],
        street: "Kammakargatan 38 lgh 1401", city: "Stockholm", country: "Sweden",
        fullName: function () { return this.firstName + " " + this.lastName; },
        numberOfRoles: function () {
            let r = 0;
            for (x of this.roles) {
                r++;
            }
            return r;
        }

    };
    console.log(person.fullName());
    console.log(person.numberOfRoles());

    //console.log(`${person.firstName} är född ${person.birthYear}`);
    //console.log(`${person.firstName} bort på gatan ${person.street}`);
    //console.log(`${person.firstName} har spelat 3 roller, bland annat ${person.role1}`);

}