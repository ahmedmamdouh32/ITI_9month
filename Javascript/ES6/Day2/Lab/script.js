// 1. Create your own function that accepts multiple parameters to
// generate course information and display it. assume course
// information must contains courseName, courseDuation,
// courseOwner. 



function MakeCourse({ courseName, courseDuration, courseOwner }, ...additionalInfo) {
    return {
        courseName: courseName,
        courseDuration: courseDuration,
        courseOwner: courseOwner,
        additionalInfo
    };
}

let c2 = MakeCourse({ courseName: 'ahmed', courseDuration: 23, courseOwner: 'mamdouh' }, 'info1', 'info2');
console.log(c2.additionalInfo);