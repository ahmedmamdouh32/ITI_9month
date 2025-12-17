function Sum(a,b){
    
    if(arguments.length < 2){
        throw "number of arguments is less than 2";
    }
    else if(arguments.length > 2){
        throw "number of arguments is more than 2";

    }
    else{
        return a+b;
    }

}

function SumN(n1,n2,n3,n4){
    console.log(SumN.length);
    if(arguments.length < SumN.length){
        throw `number of arguments is less than ${SumN.length}`;
    }
    else if(arguments.length > SumN.length){
        throw `number of arguments is more than ${SumN.length}`;

    }
    else if(isNaN(n1) + isNaN(n2)+ isNaN(n3)+ isNaN(n4) > 0){
        throw "invalid iput datatype";
    }

    return n1+n2+n3+n4;
}


SumN(1,2,3,"5")

var obj = {
    Name : "ahmed",
    age : 23
}