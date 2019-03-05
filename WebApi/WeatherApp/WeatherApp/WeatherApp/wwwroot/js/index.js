let day = document.getElementById("day");
let weatherP = document.getElementById("weatherP")
let clientValidation = document.getElementById("clientValidation");

function CheckWeather() {
    errorP.innerText = "";
    weatherP.innerText = "";
    if (!clientValidation.checked || Validate()) {
        ControlWeather();
    }

}

function Validate() {

    if (!/\S/.test(day.value)) {
        errorP.innerText = "Du måste ange en veckodag / klienten";
        return false;
    }

    else
        return true;
}

async function ControlWeather() {

    let response = await fetch(`api/GetWeather?day=${day.value}`);

    if (response.status === 200) {
        let weather = await response.text();
        weatherP.innerText = `${weather} `
    }

    if (response.status === 204) {
        errorP.innerText = `Det finns ingen väderprognos för ${day.value.toLowerCase()}`
    }

    if (response.status === 400) {
        let error = await response.text();
        errorP.innerText = `${error}`
    }

    if (response.status === 500) {
        errorP.innerText = `FATALT FEL!`;
    }
}