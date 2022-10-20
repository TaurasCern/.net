function isTransferYear(year){
    return year % 4 === 0 /*&& age % 100 === 0 && age % 400 === 0*/;
}

window.alert((isTransferYear(window.prompt())) ? "Keliamieji" : "Ne keliamieji");