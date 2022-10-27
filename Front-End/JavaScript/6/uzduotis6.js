let accords = [`D`, `G`, `C`, `C7`, `F`]

function solve(accords, func){
    for (let i = 0; i < accords.length; i++) {
        accords[i] = endsWithSeven(accords[i])
    }
}
function endsWithSeven(accord){
    if(!accord.endsWith(`7`)){    
        accord += + `7`;
    } 
    return accord;
}

solve(accords);
console.table(accords);
