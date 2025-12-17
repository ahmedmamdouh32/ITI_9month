var xhr = new XMLHttpRequest();
var usersTable = document.getElementById("data");
var allUserData= document.getElementById("allUserData");
var responseData =[];

usersButton = document.getElementById("UsersButton");

usersButton.addEventListener("click",function(){
    console.log('1');
    xhr.open("Get","https://jsonplaceholder.typicode.com/users");
    xhr.send();
    xhr.onreadystatechange = 
    function(){
        if(xhr.status === 200 && xhr.readyState === 4){
                responseData = JSON.parse(xhr.response) 
                printUsers(responseData);
            }
    }
})

function printUsers(users){
    for(var user of users){
        usersTable.innerHTML+=
        `
        <tr>
            <td>${user.id}</td>
            <td>${user.name}</td>
            <td>${user.email}</td>
            <td onclick='getUserDetails(${JSON.stringify(user)})' class="view-details-cell">View Details</td>
        </tr>
        `;
    }
}

function getUserDetails(value){
    console.log(`${JSON.stringify(value)} users data`);
    allUserData.innerHTML=
    `
    <p>Name : ${value.id}</p>
    <p>Email : ${value.name}</p>
    <p>Address : <br> City: ${value.address.city} <br> Street: ${value.address.street}</p>
    <p>Website : ${value.website} </p>
    `
}