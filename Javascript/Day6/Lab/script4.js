var Person = function(name, Age){
    this.Name = name;
    this.Age = Age;

    this.getAge = function(){
        return this.Age;
    }
}



var person1 = new Person("ahmed",12);

console.log(person1.__proto__)
age = 23
Name = "ahmed"
salary = 12.3
names =["ahmed","ayman"];
// console.log(person1.__proto__)
// console.log(Name.__proto__)
// console.log(salary.__proto__)
// console.log(age.__proto__ === Number.prototype)
// numbers = [1,2,3]
// // numbers.pop()
// str = numbers.toString();
// console.log(str);
// function nigga(){
//     return 1;
// }

// // console.log(nigga.__proto__);
// console.log(age.__proto__);
// console.log(age.prototype);
// console.log(nigga.prototype);

// var firstName = "ahmed";
// console.log(String.isprot)

// var Name2 = {fName:"Ahmed", lName:"Mamdouh"};
// console.log(Object.prototype.isPrototypeOf(Name2));