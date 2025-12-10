var elementsArray = [];
var user_input;
var sumResult = 0
var multiplyResult = 1
for(var i=0 ; i < 3 ; i++){
    
    do{
        var printedIndex = i + 1
        user_input = prompt("Enter Number " + printedIndex + " :")
    }
    while (isNaN(user_input - 0))
    user_input = Number(user_input);
    elementsArray.push(user_input);
    sumResult+=user_input;
    multiplyResult*=user_input;
}

var result = elementsArray[0] + elementsArray[1] + elementsArray[2]
document.writeln("<p>sum of the 3 values ", elementsArray[0], " + ", elementsArray[1], " + ", elementsArray[2]," = ",sumResult, "</p>")
document.writeln("<p>multiplication of the 3 values ", elementsArray[0], " * ", elementsArray[1], " * ", elementsArray[2]," = ",multiplyResult, "</p>")


if(elementsArray[1] == 0 || elementsArray[2] == 0){
    document.writeln("<p>division of the 3 values ", elementsArray[0], " / ", elementsArray[1], " / ", elementsArray[2]," = infinity", "</p>")
}
else{
    var divisionResult = elementsArray[0]/elementsArray[1]/elementsArray[2];
    document.writeln("<p>division of the 3 values ", elementsArray[0], " / ", elementsArray[1], " / ", elementsArray[2]," = ",divisionResult, "</p>")
}

