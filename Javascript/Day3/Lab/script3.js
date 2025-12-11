var numbers = [2,3,61,61,62,1,40,0,40]

//function using Set 
function second_L_S(numbers)
{
    numbers = numbers.sort((a,b)=>a-b)
    numbers = new Set(numbers); //converting to Set to remove duplicates
    numbers = [...numbers] //returning back to array to access elements by index
    var secondLargest = numbers[numbers.length-2]
    var secondSmallest = numbers[1]
    return [secondSmallest,secondLargest]
}


function getArrayUnique(numbers){
    var uniqueArray = [];
    numbers = numbers.sort((a,b) => (a-b) );
    var currentNumber = numbers[0];
    uniqueArray.push(currentNumber);
    for(var i = 1 ; i < numbers.length;i++){
        if(numbers[i] !== currentNumber) {
            currentNumber = numbers[i];
            uniqueArray.push(currentNumber);
        }
    }
    return uniqueArray
}


//fuuction using user-defined function
function second_L_S_V2(numbers)
{
    getArrayUnique(numbers)
    var secondLargest = numbers[numbers.length-2]
    var secondSmallest = numbers[1]
    return [secondSmallest,secondLargest]
}


console.log(second_L_S(numbers))
console.log(second_L_S_V2(numbers))