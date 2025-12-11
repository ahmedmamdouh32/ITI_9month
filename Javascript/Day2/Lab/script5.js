var sentence = prompt("Enter a string : ")
var eIndexes =[]
var letter = prompt("Enter a Letter : ")
for(var i =0 ; i<sentence.length;i++){
    if(sentence[i] === letter){
        eIndexes.push(i);
    }
}
document.writeln("<p>"+eIndexes+"</p>");

