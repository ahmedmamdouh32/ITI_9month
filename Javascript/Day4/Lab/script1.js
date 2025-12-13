userData = document.getElementsByName("userData")
userNameError = document.getElementById("userNameError");
userAgeError = document.getElementById("userAgeError");
table = document.getElementById("studentsTable");
var IDCounter = 1;
var userName;
var useAge;

function getUserData(){
    userName = userData[0].value;
    if(userName.length === 0){
        userNameError.innerText="Please Enter Value Here !"
        userNameError.style.display = "block";
        return;
    }
    else if(userName.length <= 3){
        userNameError.innerText="Length must be greater than 3!"
        userNameError.style.display = "block";
        return;
    }
    else{
        userNameError.style.display = "none";
    }

    userAge = userData[1].value;
    if(isNaN(userAge - '0')){
        userAgeError.innerText = "Enter Numbers only !";
        userAgeError.style.display="block";
        return;
    }
    else if(userAge === ''){
        userAgeError.innerText = "Please Enter Value Here !";
        userAgeError.style.display="block";
        return;
    }
    else{
        userAge = Number(userAge);
        if(userAge < 19){
            userAgeError.innerText = "Age Must be greater than 18 !";
            userAgeError.style.display="block";
            return;
        }
        else{
            userAgeError.style.display="none";
        }
    }
    var RowData = [IDCounter,userName,userAge]
    var newRow = table.insertRow(-1); //insert at the end
    for(var i = 0 ; i<RowData.length;i++){
        var newCell = newRow.insertCell(i);
        newCell.innerText=RowData[i];
    }
    var newCell = newRow.insertCell(3);
    newCell.innerHTML =`<button class="userButton"  onclick="deleteStudnet(name)" name="b${IDCounter}">Delete</button>`
    IDCounter++;

}


function deleteStudnet(n){
    for(var i = 1;i<=table.rows.length;i++){
        if(n === table.rows[i].cells[3].querySelector("button").name){
            table.deleteRow(i);
            break;
            // console.log(table.rows[i].cells[3])
        }
    }
}






    

    