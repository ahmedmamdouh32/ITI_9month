//1. Write a function createCounter that returns another
//function. The returned function should increment a
//counter each time

function creatCounter() {
    var counter = 0;
    return function () {
        return counter++;
    }
}

var c = creatCounter();
console.log(c());
console.log(c());
console.log(c());


//2. Create a recursive function factorial that takes a number
//n and returns its factorial.Test the function with various
//values

function fact(result) {
    if (result === 1)
        return 1;
    return result * fact(result - 1);
}
console.log(fact(6)); //720
console.log(fact(5)); //120
console.log(fact(4)); //24
console.log(fact(3)); //6


//3. Write a function memoizedFactorial that calculates the
//factorial of a number and caches results to improve
//performance on repeated calls 
function memoFact(fn) {
    var dict = {}; //storage for values and results
    return function (number) {
        if (String(number) in dict) {
            console.log("found by searching..");
            return dict[number];
        }
        var result = fn(number); //catch the factorial
        dict[number] = result;
        console.log("found by calculations...");
        return result;
    }
}

var result = memoFact(fact);

console.log(result(2));
console.log(result(5));
console.log(result(2));
console.log(result(5));



//4. Write a function constructor Person that takes name and
//age as parameters and assigns them to the instance.
//Create an instance of Person and log the properties
function Person(name, age) {
    this.name = name;
    this.age = age;
}

var p1 = new Person("ahmed", 23);
var p2 = new Person("hany", 28);
console.log(p1.name + " " + p1.age);
console.log(p2.name + " " + p2.age);


//4.2 add a method greet to the Person constructor that logs
//a greeting message including the person’s name.Test
//this by calling greet on an instance of Person.
function Person2(name, age) {
    this.name = name;
    this.age = age;
    this.greeting = function () {
        return `Hello ${name}`;
    };
}

var p3 = new Person2("ahmed", 23);
var p4 = new Person2("hany", 28);
console.log(p3.greeting());
console.log(p4.greeting());

//4.3 Refactor the Person constructor by moving the greet 
//method to Person.prototype.Create multiple instances 
//and test that they all share the same greet method
//    (i.e., it doesn’t duplicate for each instance). 
function Person3(name, age) {
    this.name = name;
    this.age = age;
}

Person3.prototype.greeting = function () {
    return `Hello ${this.name}`;
};

var p5 = new Person3("ahmed", 23);
var p6 = new Person3("hany", 28);
console.log(p5.greeting());
console.log(p6.greeting());


//5. Write a factory function createUser that can generate
//Admin and Guest users based on a configuration object.
//Each type of user should have unique methods(admin
//with manageUsers, guest with viewContent).
function createUsers(type, userName) {
    this.userName = userName;
    this.type = type;
    if (type.toLowerCase() === "admin") {
        this.manageUsers = function () {
            return `${this.userName} is managing users.`;
        }
    }
    else {
        this.viewContent = function () {
            return `${this.userName} is viewing content`;
        }
    }
}
var userAdmin = new createUsers("Admin", "mostafa");
var userGuest = new createUsers("Guest", "mostafa");
console.log(userAdmin.manageUsers());
console.log(userGuest.viewContent());

