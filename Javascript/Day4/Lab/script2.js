function showResults(){
    var userInput = document.getElementsByName("inputData");
    var tagsNumbers = document.getElementsByTagName(userInput[0].value).length;
    console.log(tagsNumbers);
    var classNumbres = document.getElementsByClassName(userInput[1].value).length
    console.log(classNumbres);
    var idStatus = document.getElementById(userInput[2].value) ? true : false;
    console.log(idStatus);
    var nameNumber = document.getElementsByName(userInput[3].value).length;
    console.log(nameNumber);

    var resultStatament = document.getElementById("lastP");
    resultStatament.innerText=`Number of ${userInput[0].value} : ${tagsNumbers}, Class ${userInput[1].value} : ${classNumbres}, ID : ${idStatus}, Name: ${nameNumber}`;

}



function toggleDarkMode() {
    document.body.classList.toggle("dark-mode");
}

f1 = (a,b) => (a+b);
console.log(f1(2,0))