function canDrink(){
    let age = window.prompt();

    
    processAge(isChild(age));
}
function processAge(isChild){
    isChild ? window.alert(window.confirm(`Ar tevai duoda leidima?`) 
            ? `Leidimas duotas`
            : `Leidimas neduotas`) 
            : window.alert("ok");
}
function isChild(age){
    return age < 18;
}


canDrink();