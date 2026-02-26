// 1)  Swap the values of two variables using destructuring
let a = 1;
let b = 2;
[a, b] = [b, a];

// 2)  Using rest parameter and spread operator return max value from any array
// note: array length is not fixed return min and max value and display each of
// them separately after function call 
function getMaxMin(...args) {
    return [Math.max(...args), Math.min(...args)];
}
let [max, min] = getMaxMin(1, 2, 3, 4, 5);
console.log(max, min);


// 3) Study new array api methods then create the following methods and apply 
// it on this array
var fruits = ["apple", "strawberry", "banana", "orange", "mango"];

// a. test that every element in the given array is a string
let result = fruits.every(fruit => typeof (fruit) === 'string');

// b. test that some of array elements starts with "a"
result = fruits.some(f => f.includes('a'));

// c. generate new array filtered from the given array with only elements that
// starts with "b" or "s"
let filteredArray = fruits.filter(f => f.startsWith('b') || f.startsWith('s'));

// d. generate new array each element of the new array contains a string 
// declaring that you like the give fruit element 
let ILikeFruits = fruits.map(f => `I Like ${f}`)

// e. use forEach to display all elements of the new array from previous point 
ILikeFruits.forEach(element => {
    console.log(element);
});

// 4. Write a function that takes an array of numbers and returns a new array 
// containing only the positive numbers. 
function Positive(arr) {
    return arr.filter(n => n >= 0);
}

// 5. Write a function that takes an array of numbers and returns the sum of all the
// numbers.(reduce) 
function Sum(arr) {
    return arr.reduce((a, b) => a + b);
}

// 6. Write a function that takes an array of names and returns a new array with
// each name capitalized. 

let Names = ['ahmed', 'tarek', 'mostafa'];

function Capitalized(names) {
    return names.map(name => name.toUpperCase());
}

// 7. Write a JavaScript program to check whether a string is lower case or not. 
function IsLower(text) {
    return text === text.toLowerCase();
}

// 8. Write an arrow function that takes an array of strings and a length, and
// returns a new array containing only the strings with length greater than the
// specified value. 
let ArrowFunc = (array, len) => array.filter(a => a.length > len);
let strings = ['hello', 'world', 'me'];
console.log(ArrowFunc(strings, 3));