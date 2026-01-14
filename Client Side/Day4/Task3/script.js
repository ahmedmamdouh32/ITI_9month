const canvas = document.getElementById("myCanvas");
const ctx = canvas.getContext("2d");
const clickButton = document.getElementById("clickButton");
const colorInput = document.getElementById("colorPicker");
var selectedColor = colorInput.value;;

colorInput.addEventListener("input", (event) => {
    selectedColor = event.target.value;
    ctx.clearRect(0, 0, canvas.width, canvas.height);
});

function drawRandomCircles() {
    for (let i = 0; i < 30; i++) {
        ctx.strokeStyle = selectedColor;
        ctx.beginPath();
        Math.random()
        ctx.arc(getRandomInRange(20, 1380), getRandomInRange(20, 680), 20, 0, Math.PI * 2); // x, y, radius, start angle, end angle
        ctx.stroke();
        ctx.strok
    }
}

function getRandomInRange(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}