let numberScreenElement = document.getElementById("number-screen");

let screenNumber =  parseInt(numberScreenElement.innerText);


let additionBtnElement = document.getElementById("addition");
let equalsBtnElement = document.getElementById("equals");

let oneElement = document.getElementById("one");
let twoElement = document.getElementById("two");

let isAdding = false;
let finalValue = 0;

oneElement.addEventListener("click", () => {

    if (isAdding) {
        finalValue = 1 +  parseInt(numberScreenElement.innerText);
        isAdding = false;
    }

    numberScreenElement.innerText = 1;
})

twoElement.addEventListener("click", () => {
    numberScreenElement.innerText = 2;
})

additionBtnElement.addEventListener("click", () => {
    isAdding = true;
})

equalsBtnElement.addEventListener("click", () => {
    numberScreenElement.innerText = finalValue;
})
