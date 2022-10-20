function farenheitToCelcius(farenheit){
    return 5/9*(farenheit-32);
}
function celciusToFarenheit(celcius){
    return celcius * 9 / 5 + 32;
}

let input = window.prompt("Celcius");
window.alert(`F: ${celciusToFarenheit(input)}\nC: ${farenheitToCelcius(celciusToFarenheit(input))}`);