function add (a,b){
    return a+b;
}

function multiply (a,b){
    return a*b;
}

function applyOperations(a,b,func){
    return func(a,b);
}

console.log(applyOperations(2,2,add))
console.log(applyOperations(2,2,multiply))
