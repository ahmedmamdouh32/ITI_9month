//--------------UserName Validation-------------------
var userName = document.getElementById("userName");
userName.style.border="5px solid red";
userName.addEventListener("input",validateUsername);
function validateUsername(){
    if(userName.value.length > 0){
        userName.style.border="5px solid green";
        return true;
    }
    else{
        userName.style.border="5px solid red";
        return false;
    }
}
//----------------------------------------------------

//----------------Email Validation--------------------
var userEmail = document.getElementById("userEmail");
userEmail.style.border="5px solid red";
userEmail.addEventListener("input",validateEmail);
function validateEmail(){
    if(/^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/.test(userEmail.value) == true){
        userEmail.style.border="5px solid green";
        return true;
    }
    else{
        userEmail.style.border="5px solid red";
        return false; 
    }
}
//----------------------------------------------------

//----------------Password Validation--------------------
var userPassword = document.getElementById("userPassword");
userPassword.style.border="5px solid red";
userPassword.addEventListener("input",validatePassword);
function validatePassword(){
    if(userPassword.value.length >= 8){
        userPassword.style.border="5px solid green";
        return true;
    }
    else{
        userPassword.style.border="5px solid red";
        return false;
    }
}
//----------------------------------------------------

//----------------Gender Validation--------------------
var userGender = document.getElementsByName("userGender");
function validateGender(){
    if(!userGender[0].checked && !userGender[1].checked){
        return false;   
    }
    else{
        return true;
    }
}
//----------------------------------------------------

//----------------Sport Validation--------------------
var userSport = document.getElementsByName("userSports");
function validateSport(){
    if(userSport[0].checked + userSport[1].checked + userSport[2].checked < 2){
        return false;
    }
    else{
        return true;
    }
}
//----------------------------------------------------

//----------------Country Validation--------------------
var userCountry = document.getElementById("userCountry");
function validateCountry()
{
    if(userCountry.value === 'Select'){
        return false;
    }
    else{
        return true;
    }
}
//----------------------------------------------------

//----------------General Validation-------------------
function generalValidation(){
    var validationStatement = "";
    if(!validateUsername()){
        validationStatement+="Username is required<br>";
    }
    if(!validateEmail()){
        validationStatement+="Enter valid Email<br>";
    }
    if(!validatePassword()){
        validationStatement+="Password should be at least 8 digits<br>"
    }
    if(!validateGender()){
        validationStatement+="Please select your Gender<br>";
    }
    if(!validateSport()){
        validationStatement+="Selecct at least two sports<br>";
    }
    if(!validateCountry()){
        validationStatement+="Please Select a country<br>";
    }
    return validationStatement;
}
//----------------------------------------------------

//-------------------Submit Button--------------------
var validationStatementTag = document.getElementById("ValidationStatement");
var submitButton = document.getElementById("buttonSubmit");
submitButton.addEventListener("click",
    function(){
        var errorStatement = generalValidation();
        if(errorStatement.length === 0){
            console.log("all is well");
            document.getElementById("formID").submit();
        }
        else{
            validationStatementTag.innerHTML=errorStatement;
        }
    }
);
//----------------------------------------------------

//-------------------Clear Button---------------------
var clearButton = document.getElementById("buttonClear");
clearButton.addEventListener("click",clearAll)
function clearAll(){
    userName.value="";
    userEmail.value="";
    userPassword.value="";
    userGender[0].checked=false;
    userGender[1].checked=false;
    userSport[0].checked=false;
    userSport[1].checked=false;
    userSport[2].checked=false;
    userCountry.value="Select";
}