var sum = 0;
for(;;){
    var value = prompt("Enter Number")
    if(isNaN(value-0)){
        confirm("Please enter valid value !!")
        continue;
    }
    value = Number(value)
    sum += value;
    if(value == 0 || sum >100){
        document.writeln("Sum = " + sum);
        break;
    }
}




