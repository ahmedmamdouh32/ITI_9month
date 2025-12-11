var numbers = [1,2,3,4,5]

function powerTwo(a){
    return Math.pow(a,2);
}

function processArray(array,func){
    var resultArray = [];
    for(var i of array){
        resultArray.push(func(i));
    }
    return resultArray
}

console.log(processArray(numbers,powerTwo));