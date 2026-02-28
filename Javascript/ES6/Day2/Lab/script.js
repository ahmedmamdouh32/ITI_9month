// 1. Create your own function that accepts multiple parameters to
// generate course information and display it. assume course
// information must contains courseName, courseDuation,
// courseOwner. 



function MakeCourse({ courseName, courseDuration, courseOwner }, ...additionalInfo) {
    return {
        courseName: courseName,
        courseDuration: courseDuration,
        courseOwner: courseOwner,
        additionalInfo
    };
}

let c2 = MakeCourse({ courseName: 'ahmed', courseDuration: 23, courseOwner: 'mamdouh' }, 'info1', 'info2');
// console.log(c2.additionalInfo);


// Promises
// a. Make your own interface to create tabs and display usernames by
// requesting users from the link below using Ajax ES6 fetch function:
// https://jsonplaceholder.typicode.com/users 
async function getUsers() {
    const response = await fetch('https://myiti.runasp.net/home/users');

    const data = await response.json();

    return data;
}

async function showUserDetails(id) {
    const response = await fetch(`https://myiti.runasp.net/home/getuser?id=${id}`);
    const userData = await response.json();

    const userContainer = document.getElementById("userDetails");
    userContainer.replaceChildren(); //to clear the container fisrt

    const name = document.createElement("h3");
    name.textContent = userData.userName;

    const age = document.createElement("p");
    age.textContent = "Age: " + userData.age;

    const country = document.createElement("p");
    country.textContent = "Country: " + userData.country;

    const email = document.createElement("p");
    email.textContent = "Email: " + userData.email;

    const phone = document.createElement("p");
    phone.textContent = "Phone: " + userData.phone;

    // container.append(name, age, country, email, phone);

    userContainer.appendChild(name);
    userContainer.appendChild(age);
    userContainer.appendChild(country);
    userContainer.appendChild(email);
    userContainer.appendChild(phone);

}

getUsers().then((data) => {

    const container = document.getElementById("usersContainer");

    data.forEach(user => {

        const button = document.createElement("button");

        button.textContent = user.userName;   // button name

        button.addEventListener("click", () => {
            showUserDetails(user.id);
        });

        container.appendChild(button);
    });
}).catch("Data not found");


