const arr = [`I`, `study`, `JavaScript`, `right`, `now`]

function solve(arr){
    arr.splice(0, 3, `Lets`, `dance`);
    console.log(arr.join(` `));
}

solve(arr);