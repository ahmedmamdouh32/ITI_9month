//1. Create a constructor Student that inherits from Person
//using call().Add an extra property school to Student and
//test if instances of Student have access to both name
//and school.
console.log("------------1--------------");


function Person(name) {
    this.name = name;
}

function Student(name, school) {
    Person.call(this,name);
    this.school = school;
}

var s1 = new Student("ahmed", "mostafa kamel");
console.log(s1.name + ", " + s1.school);



//2. Extend the Student constructor from the previous task
//by adding a greet method that overrides the greet
//method in Person to include the school property.Call
//greet on an instance of Student and check that it logs
//both name and school.
console.log("------------2--------------");


function Person(name) {
    this.name = name;
    this.greet = function () {
        return "Name : " + name;
    }
}


function Student(name, school) {
    Person.call(this, name);
    this.greet = function () {
        return  "Name : "+name + ", School : " +school ;
    }
    this.school = school;
}

var s1 = new Student("ahmed", "mostafa kamel");
var p1 = new Person("ahmed");
console.log(p1.greet());
console.log(s1.greet());



//3. Add a static method compareAge to the Person
//constructor that takes two Person objects and logs who
//is older.Call Person.compareAge(person1, person2) and
//test it with different ages. 
console.log("------------3--------------");

function Person(name, age) {
    this.name = name;
    this.age = age;
    this.greet = function () {
        return "Name : " + name;
    }
}

Person.CompareAge = function (person1, person2) {
    if (person1.age > person2.age) {
        return person1.name + " is older";
    }
    else if (person1.age < person2.age) {
        return person2.name + " is older";
    }
    else {
        return person1.name + " & " + person2.name + " are the same age";
    }
}


var p2 = new Person("Ahmed", 24);
var p3 = new Person("Hany", 25);
console.log(Person.CompareAge(p2, p3));


//4. Modify the Person constructor to create a private ssn
//(social security number) property that can only be
//accessed through a getSSN method. Demonstrate that
//ssn is inaccessible directly from outside the constructor.
console.log("------------4--------------");

function Person(name, age, _ssn) {
    var ssn = _ssn;
    this.name = name;
    this.age = age;
    this.greet = function () {
        return "Name : " + name;
    }
    this.getSSN = function () {
        return ssn;
    }
}

var p4 = new Person("tarek", 30, 123);
console.log(p4.ssn) //undefined
console.log(p4.getSSN()) //123