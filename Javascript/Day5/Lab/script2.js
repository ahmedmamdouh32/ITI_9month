redLED = document.getElementById("redLED");
orangeLED = document.getElementById("orangeLED");
greenLED = document.getElementById("greenLED");
statusWord = document.getElementById("statusWord")
var LEDsNames = ['r','o','g'];
var currentLedIndex = 0;
var currentLED;
var offColor = `rgb(${157},${157},${157})`;
var timeoutEventHandler = setInterval(function(){
    openLED(LEDsNames[currentLedIndex]);
    currentLedIndex === LEDsNames.length-1 ? currentLedIndex = 0 : currentLedIndex++;
},1000);



function openLED(LEDName){
    switch(LEDName)
    {
        
        case 'r':
            redLED.style.backgroundColor="red";
            orangeLED.style.backgroundColor=offColor;
            greenLED.style.backgroundColor=offColor;
            statusWord.style.color = "red";
            statusWord.textContent = "Stop";
            break;
        case 'o':
            redLED.style.backgroundColor=offColor;
            orangeLED.style.backgroundColor="orange";
            greenLED.style.backgroundColor=offColor;
            statusWord.style.color = "orange";
            statusWord.textContent = "Steady";
            break;
        case 'g':
            redLED.style.backgroundColor=offColor;
            orangeLED.style.backgroundColor=offColor;
            greenLED.style.backgroundColor="green";
            statusWord.style.color = "green";
            statusWord.textContent = "Go";
            break;
    }

}