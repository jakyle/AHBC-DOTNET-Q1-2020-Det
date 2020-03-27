const entireDom = document;

const helloButton = document.getElementById("hello-btn");
const addListItemButton = document.getElementById("add-list-item");

function clickHandler() {
    alert("Hello world!");
}

function addListItemHandler() {
    const listElement = document.getElementById("list");

    const listItemElement = document.createElement("li");
    listItemElement.innerText = "Hi, I'm just an item tee hee hee";

    listElement.appendChild(listItemElement);
}

helloButton.addEventListener("click", clickHandler);
addListItemButton.addEventListener("click", addListItemHandler);

const containerElement = document.getElementById("container");

const obj = {
    name: "James",
    age: 31
}


console.log(containerElement);
console.log(obj);
console.log(helloButton);

console.log(document);