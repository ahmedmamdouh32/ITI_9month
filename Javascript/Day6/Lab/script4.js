// var person = {
//     type: "human",
//     sayHi() {
//         console.log("السلام عليكم");
//     }
// };



// var student = {
//     username: "Hany"
// }
// Object.setPrototypeOf(student, person);

// student.sayHi();
// console.log(student.username);




var A = {
    sayHi() {
        console.log("السلام عليكم");
    }
};

var B = {
    tooLazy() {
        console.log("Lazzzzzy");
    }
};

var C = Object.create(B);

C.sayHi(); //undefined --> undefined() leads to an error!!.

Object.setPrototypeOf(C, A);
C.sayHi() //السلام عليكم
