var userName;
var phoneNumber;
var mobileNumber;
var email;
var colorChoice;
var textColor;

// //getting name
for(;;){
    userName = prompt("Enter Your Name : ")
    if(/^[A-Za-z]+$/.test(userName) == false){
        confirm("Please Enter Valid Name !!!")
        continue;
    }
    else{
        break;
    }
}

//getting phone number
for(;;){
    phoneNumber = prompt("Enter Your Phone Number (8 digits only): ")
    if(/^[0-9]{8}$/.test(phoneNumber) == false){
        confirm("Please Enter Valid Name !!!")
        continue;
    }
    else{
        break;
    }
}

for(;;){
    phoneNumber = prompt("Enter Your Phone Number (11 digits only): ")
    if(/^[011,012,010]{3}[0-9]{8}$/.test(phoneNumber) == false){
        confirm("Please Enter Valid Mobile Number !!!")
        continue;
    }
    else{
        break;
    }
}

for(;;){
    email = prompt("Enter Your Email Address : ")
    if(/^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/.test(email) == false){
        confirm("Please Enter Valid Email Address !!!")
        continue;
    }
    else{
        break;
    }
}

for(;;){
    colorChoice = prompt("Choose Color Format Number : '1':Red , '2':Blue , '3':Green ")
    if(colorChoice > 3 || colorChoice < 1){
        confirm("Please Enter Valid Choice !!!")
        continue;
    }
    else{
        colorChoice = Number(colorChoice);
        break;
    }
}

switch(colorChoice){
    case 1:
        textColor = "red";
    break;
    case 2:
        textColor = "blue";
    break;
    case 3:
        textColor = "green";
}

document.writeln("<h1>Entering user Info</h1>")
document.writeln("<hr>")
document.writeln('<p style="color:'+ textColor+';">Welcome Dear Guest '+userName+'</p>');
document.writeln('<p style="color:'+ textColor+';">Your Telephone Number : '+phoneNumber+'</p>');
document.writeln('<p style="color:'+ textColor+';">Your Moblie Number : '+mobileNumber+'</p>');
document.writeln('<p style="color:'+ textColor+';">Your Email  : '+email+'</p>');



var today = new Date();
var year = today.getFullYear();
var month = today.getMonth() + 1;
var day = today.getDate();
document.writeln('<p style="color:'+ textColor+';">Today is  : '+today.getDate()+'</p>');
document.writeln('<p style="color:'+ textColor+';">You Are in month  : '+today.getMonth()+1+'</p>');
document.writeln('<p style="color:'+ textColor+';">and Year  : '+today.getFullYear()+1+'</p>');
document.writeln('<p style="color:'+ textColor+';">today is  : '+today.toDateString()+'</p>');








