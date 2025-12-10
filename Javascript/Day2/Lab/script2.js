var isBalendrom = true;
var user_input = prompt("Enter a Word : ");

if(confirm("Do you want it Case Sensitive ?") == false)
{
    user_input = user_input.toLowerCase();
}

for(var i =0;i<user_input.length/2;i++){
    if(user_input[i] != user_input[user_input.length-1-i]){
        isBalendrom = false;
        break;
    }
}

if(isBalendrom === true){
    document.writeln("<p>Palindrome</p>")
}
else{
    document.writeln("<p>Not Palindrome</p>")
}