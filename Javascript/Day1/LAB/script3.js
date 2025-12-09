for(;;){
    var value = prompt("Enter Number")
    if(isNaN(value-0)){
        confirm("Please enter valid value !!")
        continue;
    }
    value = Number(value)
    if(value % 3 == 0 && value % 5 == 0){
        confirm("fizzbuzz")
    }
    else if(value % 3 == 0){
        confirm("fizz")
    }
    else if(value % 5  == 0){
        confirm("buzz")
    }
    else{
        confirm("none")
    }
}