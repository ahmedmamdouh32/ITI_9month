var messageButton = document.getElementById("messageButton");
var newWindowHandler;
var timeIntervalHandler;
var sentence = "This is Ahmed Mamdouh from track Professional Development & BI-Infused CRM -ITI-";
var currentCharIndex=0;
messageButton.addEventListener("click",function(){
    newWindowHandler = open("","_blank" ,"width=600px,height=200px"); 
    timeIntervalHandler = setInterval(() => addCharacter(sentence[currentCharIndex]), 100);
});

function addCharacter(char){
    if(newWindowHandler !== 'undefined')
    {
        newWindowHandler.document.write(char);
        currentCharIndex === sentence.length-1 ? clearInterval(timeIntervalHandler) : currentCharIndex++;
    }
    else
    {
        console.log("the page is not opened yet");
    }
}


