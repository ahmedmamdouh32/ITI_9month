function upperFirstLetter(word){
    var uppercaseString = "";
    uppercaseString+=word[0].toUpperCase();
    for(var i = 1; i <word.length;i++){
        if(word[i-1] === ' '){
            uppercaseString += word[i].toUpperCase();
        }
        else{
            uppercaseString+=word[i];
        }
    }
    return uppercaseString;
}
console.log(upperFirstLetter("ahmed mamoduh"))