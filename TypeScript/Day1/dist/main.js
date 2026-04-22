import { } from "./models";
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
//# sourceMappingURL=main.js.map