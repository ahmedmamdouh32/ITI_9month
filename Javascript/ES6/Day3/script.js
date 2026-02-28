//1) Proxy
const person = new Proxy({}, {
    set(target, prop, value) {

        if (!["name", "address", "age"].includes(prop)) {
            throw new Error(`Property "${prop}" is not allowed.`);
        }


        if (prop === "name") {
            if (typeof value !== "string" || value.length !== 7) {
                throw new Error("Name must be a string of exactly 7 characters.");
            }
        }

        if (prop === "address") {
            if (typeof value !== "string") {
                throw new Error("Address must be a string.");
            }
        }

        if (prop === "age") {
            if (typeof value !== "number" || value < 25 || value > 60) {
                throw new Error("Age must be a number between 25 and 60.");
            }
        }

        target[prop] = value;
        return true;
    }
});



//2) Using ES6 new Syntax & features:
import { Rectangle, Square, Circle } from './shapes.js';

const rect = new Rectangle(10, 5);
const square = new Square(6);
const circle = new Circle(4);

console.log(rect.toString());
console.log(square.toString());
console.log(circle.toString());


// 3) generator 
//A) 
function* fibonacciByCount(count) {
    let a = 0, b = 1;

    for (let i = 0; i < count; i++) {
        yield a;
        [a, b] = [b, a + b]; // swap + update
    }
}

const fib1 = fibonacciByCount(7);

for (let num of fib1) {
    console.log(num);
}


//B)
function* fibonacciByMax(max) {
    let a = 0, b = 1;

    while (a <= max) {
        yield a;
        [a, b] = [b, a + b];
    }
}

const fib2 = fibonacciByMax(20);

for (let num of fib2) {
    console.log(num);
}

//4) Iterator

let user = {
    name: 'ahmed',
    age: 24,
    email: 'ahmed@gmail.com',
    [Symbol.iterator]: function () {
        const keys = Object.keys(this);
        let index = 0;
        return {
            next: () => {
                if (index < keys.length)
                    return { value: { key: keys[index], value: this[keys[index++]] }, done: false }
                else {
                    return { value: undefined, done: true }
                }
            }
        }
    }
}


for (const item of user) {
    console.log(item);
}



