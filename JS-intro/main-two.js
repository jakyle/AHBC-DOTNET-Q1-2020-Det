let helloWorldTwoBtnElement = document.getElementById("hello-world-btn");

function addTwoNums() {
    return 1 + 1;
}


let result = addTwoNums();


function helloWorldClick() {
    alert("Hello world for a second time!!!");
}

helloWorldTwoBtnElement.addEventListener("click",  helloWorldClick);


function closureExample(fn) {
    let result = fn();
    console.log(`hey, this is the result of our call back function: ${result}`);
}

closureExample(addTwoNums);

let incrementorBtnElement = document.getElementById("number-incrementor-btn");

let sum = 0;
incrementorBtnElement.addEventListener("click",  () => {
    sum++;
    alert(`Current Value = ${sum}`);
} )
