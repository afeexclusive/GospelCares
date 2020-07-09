// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Declarations
let needSelector = document.getElementById("needforhelp");
let activeBank = document.getElementById("selectbank");
//let bankSelect = activeBank.options[activeBank.selectedIndex].text;
let val = document.getElementById("valbtn");
let paval = document.getElementById("pastvalbtn");

//if (bankSelect == "Select Bank") {
//    document.getElementById("non-select").style.display = "none";
//}

//Invoke functions
val.addEventListener("click", validate);
paval.addEventListener("click", pastvalidate);
needSelector.addEventListener("change", capturetext);
activeBank.addEventListener("change", showBankCode);

// Functions
function validate() {
    let passcode = "444aaa555";
    let inputcode = document.getElementById('txtcode').value;
    if (inputcode == passcode) {
        document.getElementById("adminpass").style.display = "Block";
    }
}


function pastvalidate() {
    let passcode = "pppppp";
    let inputcode = document.getElementById('pastortxtcode').value;
    if (inputcode == passcode) {
        document.getElementById("pastorpass").style.display = "Block";
    }
}

function showBankDetails(iSelect) {
    
    if (iSelect == "Food") {
        document.getElementById("accountDetails").style.display = "none";
    } else {
        document.getElementById("accountDetails").style.display = "block";
    }
}

function capturetext() {
    let index = needSelector.selectedIndex;
    let iSelect = document.getElementById("needforhelp").options[index].text;
    showBankDetails(iSelect);
}

function showBankCode() {
    document.getElementById("non-select").style.display = "block";
    let bSelect = activeBank.options[activeBank.selectedIndex].text;
    if (bSelect == "Access") {
        document.getElementById("codedisplay").innerText = "*901#";
    } else if (bSelect == "Eco Bank") {
        document.getElementById("codedisplay").innerText = "*326#";
    } else if (bSelect == "FCMB") {
        document.getElementById("codedisplay").innerText = "*329#";
    } else if (bSelect == "Fidelity Bank") {
        document.getElementById("codedisplay").innerText = "*770#";
    } else if (bSelect == "First Bank") {
        document.getElementById("codedisplay").innerText = "*894#";
    } else if (bSelect == "GTBank") {
        document.getElementById("codedisplay").innerText = "*737#";
    } else if (bSelect == "Polaris(Skye)") {
        document.getElementById("codedisplay").innerText = "*833#";
    } else if (bSelect == "Stanbic IBTC") {
        document.getElementById("codedisplay").innerText = "*909#";
    } else if (bSelect == "Sterling Bank") {
        document.getElementById("codedisplay").innerText = "*822#";
    } else if (bSelect == "UBA") {
        document.getElementById("codedisplay").innerText = "*919#";
    } else if (bSelect == "Unity Bank") {
        document.getElementById("codedisplay").innerText = "*7799#";
    } else if (bSelect == "Wema") {
        document.getElementById("codedisplay").innerText = "*945#";
    } else if (bSelect == "Zenith") {
        document.getElementById("codedisplay").innerText = "*966#";
    } else {
        document.getElementById("non-select").style.display = "none";
    }
}