let color1 = "green";
let color2 = 'teal';
let color3 = `yellow`;

console.log("Color1: " + color1)
console.log("Color2: " + color2)
console.log("Color3: " + color3)

let numberOne = 10;
let numberTwo = 80;
let numberThree = 15.78;
let numberFour = 15.3333333333333333333333333333333333;


console.log(numberOne);
console.log(numberTwo);
console.log(numberThree);
console.log(numberFour);

const bigInt = 123123131231312313123131231231231231312313131313132131n;
console.log(bigInt);

const hugeString = BigInt("9457328672385967023489565");
console.log(hugeString);

const hugeHex = BigInt("0x1ffffffffffff");
const hugeOctal = BigInt("0o377777777777777");
const hugeVin = BigInt("0b111111111111111111111111111111111111111");

let billion = 1e9;
console.log(billion)

console.log(0/0);
console.log(1/0);
console.log(0/NaN);
console.log(-1/0);

let isNaNeualNaN = NaN == NaN;
console.log(isNaNeualNaN);

console.log(200+0/0);

var age = prompt("Enter your age");
console.log(age);


var no1 = prompt("number 1");
var no2 = prompt("number 2");
console.log(parseInt(no1) + parseInt(no2))