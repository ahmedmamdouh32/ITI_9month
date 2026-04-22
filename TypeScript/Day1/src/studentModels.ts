// Modules
// Create a file studentModels.ts.
// Define and export:
// Type alias ID = string | number
// Interface Student with:
// id: ID
// name: string
// age?: number (optional)
// grade: string

export type ID_SM = (string | number);

export interface Student_SM {
    id: ID_SM,
    name: string,
    age?: number,
    grade: string
}

// Enum
// Create an enum Status with values: Active, Graduated, Suspended.
// Add a property status: Status to the Student interface.

export enum Status_SM {
    Active,
    Graduated,
    Suspended
}

export interface Student_SM {
    status: Status_SM
}

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
    students: Student_SM[] = [];
    static totalStudents: number = 0;


    //methods:
    AddStudent(student: Student_SM): void {
        this.students.push(student);
        StudentManager_SM.totalStudents++;
    }

    printStudents(showAge?: boolean): void {
        this.students.forEach((st => {
            console.log(`Student Name : ${st.name}`);
            if (showAge === true && st.age) {
                console.log(`Age ${st.age}`)
            }
        }));
    }
}

// Generic Function
// Create a generic function printArray<T>(items: T[]): void that prints any array of
// items.


export function printArray_SM<T>(items: T[]): void {
    items.forEach((item => {
        console.log(item);
    }))
}




