let candies = []

for (let i = 0; i < 3; i++) {
    let price = prompt("Kaina:");
    let name = prompt("Pavadinimas:");
    let weight = prompt("Svoris:");
    
    candies[i] = {
        price: price,
        name: name,
        weight: weight,
    }
}

console.table(candies);