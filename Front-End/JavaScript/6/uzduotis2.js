let child = {
    name: `Petras`,
    toysArray: [`toy1`, `toy2`, `toy3`],
    yearsOld: 7,
    birthday: true,
    totalToys: null,
    friends: [
    {
        name: `Antanas`,
        action: `Sleeping`
    },
    {
        name: `Stasys`,
        action: `Playing games`
    },
    {
        name: `Antanas`,
        action: `Traveling`
    }]
}
function birthday(givenName){
    if(child.name === givenName && child.birthday === true){
        child.toysArray.shift();
        child.toysArray.push(`toy4`);
        child.yearsOld++;
        child.totalToys = child.toysArray.length;
        console.table(child.friends);
    }
}

birthday(`Petras`)
console.table(child);