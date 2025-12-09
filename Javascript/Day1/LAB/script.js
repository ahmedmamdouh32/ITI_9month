var buttonsNumbers =  prompt("Enter Number Of Buttons");
var buttonsBreaker =  prompt("Enter Breaker Range ");

buttonsNumbers = Number(buttonsNumbers)
buttonsBreaker = Number(buttonsBreaker)
buttonsBreaker = buttonsBreaker<=0  ? 1 : buttonsBreaker
for(var i = 1 ; i<=buttonsNumbers;i++){
    document.writeln("<button>Button"+i+"</button>")
    if(i % buttonsBreaker == 0){
        document.writeln("<br>")
    }
}