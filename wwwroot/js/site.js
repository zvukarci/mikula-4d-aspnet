// task6
function toggleText() {
    document.getElementById("toggle-text").classList.toggle("hidden");
}

// task7
let clickCount = 0;
const clickButton = document.getElementById("click-button");
const clickCountDisplay = document.getElementById("click-count");
const container = clickButton.parentElement;

clickButton.addEventListener("click", () => {
    clickCount++;
    clickCountDisplay.textContent = clickCount;
    if (clickCount >= 5) {
        container.classList.add("background-changed");
    }
});
