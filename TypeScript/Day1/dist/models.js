// Task 1 – 
//  Create a file models.ts and define:
// A type alias ID = string | number
// An interface Student with properties: id: ID, name: string, age ?: number, grade:
// string
// What to do:
// Export the interface and type.
// In another file app.ts, import them and create an array of 3 students.
// Print the names of the students
// Task 2
//  Create an Enum Status with values: Active, Graduated, Suspended.
// What to do:
// Create a variable studentStatus of type Status and assign it Active.
// Print the value of studentStatus
export var Status;
(function (Status) {
    Status[Status["Active"] = 0] = "Active";
    Status[Status["Graduated"] = 1] = "Graduated";
    Status[Status["Suspended"] = 2] = "Suspended";
})(Status || (Status = {}));
//# sourceMappingURL=models.js.map