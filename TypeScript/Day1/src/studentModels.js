// Modules
// Create a file studentModels.ts.
// Define and export:
// Type alias ID = string | number
// Interface Student with:
// id: ID
// name: string
// age?: number (optional)
// grade: string
// Enum
// Create an enum Status with values: Active, Graduated, Suspended.
// Add a property status: Status to the Student interface.
export var Status_SM;
(function (Status_SM) {
    Status_SM[Status_SM["Active"] = 0] = "Active";
    Status_SM[Status_SM["Graduated"] = 1] = "Graduated";
    Status_SM[Status_SM["Suspended"] = 2] = "Suspended";
})(Status_SM || (Status_SM = {}));
// Class
// Create a class StudentManager with:
// private students: Student[]
// static totalStudents: number = 0
// Add methods:
// addStudent(student: Student): void →
//  adds student to the array and
// increments totalStudents
// printStudents(showAge ?: boolean): void →
//  prints student info.If showAge is
// true, also print age(default: false)
export class StudentManager_SM {
    students = [];
    static totalStudents = 0;
    //methods:
    AddStudent(student) {
        this.students.push(student);
        StudentManager_SM.totalStudents++;
    }
    printStudent(showAge) {
        this.students.forEach((st => {
            console.log(`Student Name : ${st.name}`);
            if (showAge === true && st.age) {
                console.log(`Age ${st.age}`);
            }
        }));
    }
}
// Generic Function
// Create a generic function printArray<T>(items: T[]): void that prints any array of
// items.
export function printArray_SM(items) {
    items.forEach((item => {
        console.log(item);
    }));
}
