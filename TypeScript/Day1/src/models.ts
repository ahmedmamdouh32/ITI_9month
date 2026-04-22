// Task 1 – 
//  Create a file models.ts and define:
// A type alias ID = string | number
// An interface Student with properties: id: ID, name: string, age ?: number, grade:
// string
// What to do:
// Export the interface and type.
// In another file app.ts, import them and create an array of 3 students.
// Print the names of the students


export type ID = (string | number);

export interface Student {
    id: ID,
    name: string,
    age?: number,
    grade: string
}


// Task 2
//  Create an Enum Status with values: Active, Graduated, Suspended.
// What to do:
// Create a variable studentStatus of type Status and assign it Active.
// Print the value of studentStatus

export enum Status {
    Active,
    Graduated,
    Suspended
}


// Task 3 
//  Create a function greetStudent that takes:
// student: Student
// showAge?: boolean 
// What to do:
// Print the student's name.
// If showAge is true and age is provided, print the age as well.
// Test calling the function with and without showAge.


export function greetStudent(student: Student, showAge?: boolean) {
    console.log(`Student Name : ${student.name}`);
    if (showAge === true && student.age) {
        console.log(`Age ${student.age}`)
    }
}


// Task 4 
// Create a generic function called getArray<T> that:
// Accepts an array of any type T
// Returns a new array containing the same elements
// Test the function with different types:
// Array of numbers: [1, 2, 3]
// Array of strings: ["apple", "banana"]
// Array of booleans: [true, false, true]
// Print the result of each call to the console

export function getArray<T>(arr: T[]): T[] {
    return [...arr];
}

// Task 5 – 
// Create a class Counter with:
// A static property count initialized to 0
// A static method increment() that increases count by 1
// What to do:
// Call Counter.increment() twice.
// Print Counter.count.
export class Counter {
    static count: number = 0;
    static increment() {
        this.count++;
    }
}


// Task 6 –
// Create a file math.ts with functions: add, subtract, multiply, divide.
// What to do:
// Export all functions.
// In app.ts, import all functions and use them on numbers.
// Print the results.

export function Add(a: number, b: number): number {
    return a + b;
}

export function Subtract(a: number, b: number): number {
    return a - b;
}

export function Multiply(a: number, b: number): number {
    return a * b;
}

export function Divide(a: number, b: number): number {
    if (b != 0) {
        return a / b
    }
    else {
        return 0;
    }
}
