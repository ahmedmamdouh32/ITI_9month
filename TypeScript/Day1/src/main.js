import { Status, greetStudent, getArray, Counter, Add, Subtract, Multiply, Divide } from "./models.js";
import { Status_SM, StudentManager_SM, printArray_SM } from "./studentModels.js";
//Task 1
let students = [
    { id: 1, name: "ahmed", age: 12, grade: "A" },
    { id: 2, name: "mostafa", age: 12, grade: "A" },
    { id: 3, name: "kareem", age: 12, grade: "A" },
];
let StudentsNames = "";
students.forEach((st) => {
    StudentsNames += `${st.name}\n`;
});
console.log(StudentsNames);
//-----------------------------------------
//Task 2
let studentStatus = Status.Active;
console.log(studentStatus);
//-----------------------------------------
//Task 3
greetStudent(students[0]);
greetStudent(students[0], true);
//-----------------------------------------
//Task 4
console.log(getArray([1, 2, 3, 4]));
console.log(getArray(['a', 'b', 'c']));
//-----------------------------------------
//Task 5
Counter.increment();
Counter.increment();
Counter.increment();
console.log(Counter.count);
//-----------------------------------------
//Task 6
console.log(Add(1, 2));
console.log(Subtract(1, 2));
console.log(Multiply(1, 2));
console.log(Divide(1, 2));
//-----------------------------------------
//Task 7
// a.Import the interface, enum, and class
// b.Create 3 students with different grades and statuses
// c.Add them to the manager
// d.Use the generic function to print all students
// e.Print the total number of students using StudentManager.totalStudent
let student1 = {
    id: 1,
    name: "Ahmed",
    grade: "A",
    age: 23,
    status: Status_SM.Active
};
let student2 = {
    id: 2,
    name: "Mostafa",
    grade: "B",
    age: 24,
    status: Status_SM.Active
};
let student3 = {
    id: 3,
    name: "Hany",
    grade: "C",
    age: 34,
    status: Status_SM.Active
};
let manager = new StudentManager_SM();
manager.AddStudent(student1);
manager.AddStudent(student2);
manager.AddStudent(student3);
printArray_SM(manager.students);
console.log(StudentManager_SM.totalStudents);
