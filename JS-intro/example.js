// ONLY variable decleration in modern javascript development will 
// either be let, or const
let name = "James";
let otherName = "Darion";

console.log(name);

name = 23;
console.log(name);

name = true;
console.log(name);

let numOne = 23;
let numTwo = "23";

if (numOne == numTwo ) {
    console.log("... thaanks javascript, for being a 'great' language");
}


if (numOne === numTwo) {
    console.log("I cannot believe javascript is letting me do this")
} else {
    console.log("Oh, look, you checked for type... good on you!")
}


function sumTwoNums(x, y) {

    if (typeof(x) === 'number' && typeof(y) === 'number') {
        return x + y;
    }

    console.error("invalid arguments, please pass in numbers for both x and y");
}

function helloWorld() {
    console.log("Hello World!");
}

function checkBoolEquality() {
    if (true == "true") {
        console.log("fuck you javascript for letting me do this...");
    }
}

let cat = new Cat("Oreo", 9);

cat.makeNoise();

let obj = {
    name: "James",
    age: 31
}

let objTwo = obj;

helloWorld();

let sumNumResult = sumTwoNums(1, 2);
console.log(sumNumResult);

let otherSumNumResult = sumTwoNums("sup", "hello");
// "suphello"

console.log(otherSumNumResult);

checkBoolEquality();

console.log(cat);

console.log(obj);

console.log(cat.age);
console.log(cat.name);


let cats = ["Tony", "Larry", "joe"];
cats.push("Josey");

let larry = cats[1];

let tony = cats.pop();

console.log(cats);

// looping
for (let i = 0; i < cats.length; i++) {
    console.log(cats[i]);
}

for (const cat of cats) {
    console.log(cat);
}

cats.forEach((cat, i) => {
    console.log(cat);
})