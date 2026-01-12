function Person(name) {
    this.name = name;
    this.printName = function(){
        return this.name;
    }
}

Person.prototype.sayHi = function () {
    // console.log("Hi, I'm " + this.name);
};



function Student(name, grade) {
    Person.call(this, name); // inherit properties
    this.grade = grade;
}

Student.prototype = Object.create(Person.prototype);


var st = new Student("Ahmed", "A");
// console.log(st)



var parent = {
    sayHello : function()
    {
        return "Hello";
    }
}

// console.log(parent.sayHello());


var child = {
Name : "Ahmed"
}

child.prototype = parent.prototype;

// console.log(child.sayHello())




const person = {
    type: "human",
    sayHi() {
    console.log("Hi");
    }
};
person.prototype.Name="ahmed";

const student = Object.create(person);
student.grade = "A";


console.log(person.type);
console.log(person.prototype.Name);
student.type = "animal";
console.log(person.type);

