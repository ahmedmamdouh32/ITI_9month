var elementsArray = [];
var user_input;
for(var i=0 ; i < 5 ; i++){
    
    do{
        var printedIndex = i + 1
        user_input = prompt("Enter Number " + printedIndex + " :")
    }
    while (isNaN(user_input - 0))
    user_input = Number(user_input);
    elementsArray.push(user_input);
}

console.log(elementsArray)
document.writeln("<p>Values you have entered : "+elementsArray+ "</p>")
document.writeln("<p>Values Sorted Ascendingly : "+elementsArray.sort(function(a,b){return a-b})+ "</p>")
document.writeln("<p>Values Sorted Descendingly : "+elementsArray.sort(function(a,b){return b-a})+ "</p>")
