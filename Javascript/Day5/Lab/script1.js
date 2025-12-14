image = document.getElementById("image");
var currentImageDisplayOrder = 0;
var timerSlidingEventHandler;
var imagesLinks = [
    "resources/img1.png",
    "resources/img2.jpg",
    "resources/img3.png",
    "resources/img4.jpg",
]
var playButton = document.getElementById("playButton");
var stopButton = document.getElementById("stopButton");
var leftArrowButton = document.getElementById("leftArrowButton")
var rightArrowButton = document.getElementById("rightArrowButton");

//---------------------------------------------------------------Sliding Functions---------------------------------------------------------------
function nextImageIndex(){
    currentImageDisplayOrder === imagesLinks.length-1 ? currentImageDisplayOrder = 0: currentImageDisplayOrder++; 
    return currentImageDisplayOrder;
}
function prevImageIndex(){
    currentImageDisplayOrder === 0 ? currentImageDisplayOrder = imagesLinks.length-1 : currentImageDisplayOrder--; 
    return currentImageDisplayOrder;
}

function startSlideShow(){
    image.src = imagesLinks[nextImageIndex()];
}

//---------------------------------------------------------------Events Handlers---------------------------------------------------------------
leftArrowButton.addEventListener("click",function(){
    image.src = imagesLinks[nextImageIndex()];
})
rightArrowButton.addEventListener("click",function(){
    image.src = imagesLinks[prevImageIndex()];
})

playButton.addEventListener("click",
    function(){
        timerSlidingEventHandler = setInterval(startSlideShow,1000);
    }
)

stopButton.addEventListener("click",
    function(){
        clearInterval(timerSlidingEventHandler);
    }
)