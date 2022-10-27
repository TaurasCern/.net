const person = {
    name: `Rosa`,
    age: 120,
    alive: false,
    interests: [`swimming`, `cards`]
};

function randomizeAge(person, newName){
    person.name = newName;
    person.age = Math.floor(Math.random() * 101) + 20;

    if(person.age < 100){
        person.alive = !person.alive;
        person.interests.push(`enjoying life`);
    }
}

randomizeAge(person, `Rose`);

console.table(person)