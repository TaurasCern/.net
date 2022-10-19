let animals = [ `animal1`, `animal2`,`animal3`,`animal4`,`animal5`,`animal6`,`animal7`]

console.log(`for`);
for (let i = 0; i < animals.length; i++) {
    console.log(animals[i]);
}

console.log(`\nforof`);
for (let animal of animals) {
    console.log(animal);
}