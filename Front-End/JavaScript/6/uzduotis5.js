let first = [
    `slice`,
    `splice`,
    `concat`
]
let second = [
    `push`,
    `pop`,
    `shift`,
    `unshift`
]

let arr = first.concat(second)
arr.push(`lenght`, 7, {subject: `methods`})

console.table(arr);