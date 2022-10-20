function askForCredentials(){
    let firstName = window.prompt();
    let lastName = window.prompt();
    let age = window.prompt();
    let email = window.prompt();

    let arr = [firstName, lastName, age, email]
    return arr;
}

function printCredentials(credentials){
    console.table(credentials)
}

let credentials = askForCredentials()
printCredentials(credentials)