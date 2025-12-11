var person = {
    name : "ahmed",
    age : 24,
    grade : "Third",
    subjects : {
        math : 97,
        arabic : 96,
        physics : 100,
        subject2 :{
            geopraphic : 90,
            history : 80
        },
    },
    gpa : 3.85
}
console.log(Object.keys(person))

function printFullObject(mainObject){
    for(i in mainObject){
        if(typeof(mainObject[i]) === 'object' ){
            printFullObject(mainObject[i]);
        }
        else{
            console.log(`${i} - ${mainObject[i]}`)
        }
    }
}

printFullObject(person)