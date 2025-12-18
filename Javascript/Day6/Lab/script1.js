
if (hasCookie("UserData")){
    console.log("found");
    var userCookie = getCookie("UserData");
    console.log(userCookie);
    userCookie = userCookie.split('-');
    userCookie[4] = Number(userCookie[4]) + 1;
    var imageSource;
    if(userCookie[2]==="Male"){
        imageSource = "resources/1.jpg";
    }
    else{
        imageSource="resources/2.jpg";
    }
    console.log("Gender : "+userCookie[2]);
    document.body.innerHTML =
            `
            <p style="color:${userCookie[3]}">Hello ${userCookie[0]} You visited this website ${userCookie[4]} times</p>
            <img src=${imageSource}>
            
            `;
    setCookie("UserData",`${userCookie[0]}-${userCookie[1]}-${userCookie[2]}-${userCookie[3]}-${userCookie[4]}`);
}


function getCookie(key){
    var cookies = document.cookie.split(';');
    for(var cookie of cookies){
        var key_value = cookie.trim().split('='); //key at [0], value at [1]
        if(key_value[0] === key){
            return key_value[1];
        }
    }
}


function setCookie(cookieName,cookieValue,expireDate){
    if(expireDate !== 'undefined'){
        document.cookie = `${cookieName}=${cookieValue}; expires=${expireDate}`;
    }
    else{
        document.cookie = `${cookieName}=${cookieValue}`;
    }
}

function deleteCookie(key){
    var previousDate = new Date();
    previousDate.setDate(previousDate.getDate()-1);
    document.cookie = `${key}=; expires=${previousDate}`;
}

function allCookieList(){
    cookies = document.cookie;
    cookies = cookies.split(';');
    var cookielist=[];
    for(var cookie of cookies){
        cookie = cookie.trim().split('=');
        cookielist.push([cookie[0],cookie[1]]);
    }
    return cookielist
}

function hasCookie(key){
    var cookies = document.cookie.split(';');
    for(var cookie of cookies){
        var key_value = cookie.trim().split('='); //key at [0], value at [1]
        if(key_value[0] === key){
            return true;
        }
    }
    return false;
}


var userNameAswer;
var userAgeAnswer;
var GenderAnswer;
var colorAnswer;
var registerButton = document.getElementById("registerButton");
var userName = document.getElementById("userName");
var userAge = document.getElementById("userAge");
var Gender = document.getElementsByClassName("Gender");
var color = document.getElementById("colorSelector");
registerButton.addEventListener("click",
    function(){
        var imageSource;
        userNameAswer = userName.value;
        userAgeAnswer = userAge.value;
        if(Gender[0].checked){
            GenderAnswer = "Male";
            imageSource = "resources/1.jpg";
        }
        else{
            GenderAnswer="Female";
            imageSource="resources/2.jpg";
        }
        colorAnswer = color.value;
        console.log(userNameAswer);
        console.log(userAgeAnswer);
        console.log(GenderAnswer);
        console.log(colorAnswer);
        var date = new Date();
        date.setDate(date.getDate() + 30); //adding persistent cookies lasts for 30 days
        setCookie("UserData",`${userNameAswer}-${userAgeAnswer}-${GenderAnswer}-${colorAnswer}-1`);
        document.writeln(
            `
            <p style="color:${colorAnswer}">Hello ${userNameAswer} You visited this website 1 times</p>
            <img src=${imageSource}>

            `
        )
    }
)