var names = ['ahmed','ashraf','ayman','tarek','fady']

function getTwoRandoms(names){

    var randomNamesArray =[]
    randomNamesArray.push(names[Math.floor(Math.random()*5)]);
    var secondName ;
    
    do{
        secondName= names[Math.floor(Math.random()*5)]
    }
    while(secondName == randomNamesArray[0])
    randomNamesArray.push(secondName)
    return randomNamesArray
}

console.log(getTwoRandoms(names))




