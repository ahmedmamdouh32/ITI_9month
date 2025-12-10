var sentence = prompt("Enter a string")
var eCounter = 0;
for(var i =0 ; i<sentence.length;i++){
    if(sentence[i] == 'e'){
        eCounter++;
    }
}

document.writeln("<p>"+eCounter+"</p>");
