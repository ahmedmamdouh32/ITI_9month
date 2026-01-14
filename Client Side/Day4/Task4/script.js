var dragFromBox = document.getElementById("dragFromBox");
var dragIntoBox = document.getElementById("dragIntoBox");
var Images = document.querySelectorAll("#dragFromBox img");
var dragFromBoxPara = document.getElementById("dragFromBoxPara");
var dragIntoBoxPara = document.getElementById("dragIntoBoxPara");
var boxStartDragging;
var currentCounter = 0;
dragFromBoxPara.innerText = `Counter : ${Images.length}`;
dragIntoBoxPara.innerText = `Counter : ${currentCounter}`
Images.forEach(img => {
    img.addEventListener("dragstart", e => {
        e.dataTransfer.setData("text/plain", img.id);
        boxStartDragging = img.parentElement.id;
        console.log(boxStartDragging);
        console.log(img.id);
    });
});

dragIntoBox.addEventListener("drop", e => {
    e.preventDefault();
    const droppedElementId = e.dataTransfer.getData("text/plain");
    console.log(droppedElementId);
    const element = document.getElementById(droppedElementId);
    if (boxStartDragging !== "dragIntoBox") {
        dragIntoBox.appendChild(element);
        currentCounter++;
        dragFromBoxPara.innerText = `Counter : ${Images.length - currentCounter}`
        dragIntoBoxPara.innerText = `Counter : ${currentCounter}`
        if (currentCounter == Images.length) {
            dragFromBox.style.visibility = "hidden";
            dragFromBoxPara.style.visibility = "hidden"
        }
    }
});

dragIntoBox.addEventListener("dragover", e => {
    e.preventDefault();
});


dragFromBox.addEventListener("drop", e => {
    e.preventDefault();
    const droppedElementId = e.dataTransfer.getData("text/plain");
    console.log(droppedElementId);
    const element = document.getElementById(droppedElementId);
    if (boxStartDragging !== "dragFromBox") {
        dragFromBox.appendChild(element);
        currentCounter--;
        dragFromBoxPara.innerText = `Counter : ${Images.length - currentCounter}`
        dragIntoBoxPara.innerText = `Counter : ${currentCounter}`
    }
});

dragFromBox.addEventListener("dragover", e => {
    e.preventDefault();
});