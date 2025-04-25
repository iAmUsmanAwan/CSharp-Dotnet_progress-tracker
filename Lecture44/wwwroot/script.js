console.log("Checking if script.js is loaded...");


const counterElement = document.getElementById("counter");
const increaseButton = document.getElementById("increase");
const decreaseButton = document.getElementById("decrease");

let count = 0;

increaseButton.addEventListener("click", () => {
    count++;
    counterElement.textContent = count;
});

decreaseButton.addEventListener("click", () => {
    count--;
    counterElement.textContent = count;
});

document.addEventListener("DOMContentLoaded", function () {
    console.log("JavaScript is running!");
});
