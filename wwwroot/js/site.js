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

// task8
const textarea = document.getElementById("textarea");
const charCount = document.getElementById("pocet-znakov");
charCount.innerHTML = textarea.value.length;

textarea.addEventListener("input", () => {
    charCount.innerHTML = textarea.value.length;
    if (textarea.value.length > 20) {
        textarea.classList.add("good");
    } else {
        textarea.classList.remove("good");
    }
});
