/**
 *   var , let , const
 *   Spread Operator
 *   Rest Parameter
 *   Destructuring
 *   Template literal
 *   arrow function
 *   nullish coalesing operator (??)
 *   optional chaining (?)
 *   Array ApI
 * 
 */

// ============================================


/**
 * 
 *   Feature               var     vs       let         vs    const
 * 
 *  Redeclaration        allow              No                  No
 * 
 *  Reassignment        yes                 yes                 No
 * 
 *  scope              Function scope     block scope         block scope
 * 
 *  hoisiting           yes (undefined)     (TDZ*)              (TDZ*)
 * 
 * attached to
 * global object
 * (window)
 * 
 */

// ========================== Redeclaration ===================

// var x = 1;
// var x = 2;

// console.log(x);



// let x = 1;
// let x = 2;

// console.log(x);



// const x = 1;
// const x = 2;
// console.log(x);


// ========================== Reassignment ===================

// var x = 1;
// x = 2;
// x = "hello";
// x = true;

// console.log(x);


// let x = 1;
// x = true
// console.log(x);


// const x = 10;

// x = 11;

// const pi = 3.14;
// pi = 10 xxxxxxxxxxxx


// =================   immutable   vs mutable    ============================


// let fname = "mona";
// fname[0] = "M";
// console.log(fname);


// let fname = "mona";
// fname = fname.slice(0,1).toUpperCase() + fname.slice(1)
// console.log(fname);

// ==================================



// let user = {
//     fname: "mona",
//     age : 30
// }

// user.age = 20;
// console.log(user);



// let arr = [1,2,3];
// arr[0] = 50;
// console.log(arr);


// ===========================

// const x = 5;
// x = 10; xxxxxxxx


// const arr = [1,2,3];

// // arr = []xxxxx

// arr[0] = 50;

// arr.push(11);
// console.log(arr);


// const user = {
//     name : "ali",
//     age : 20
// }


// // user = {} xxxxx

// user.age = 30;
// console.log(user);


// ==============================

// const arr = [1,2,3]
// Object.freeze(arr);

// arr[0] = 10;

// arr.push(40);
// console.log(arr);


// let user = {
//     fname: "mona",
//     age : 20
// }


// Object.freeze(user);
// user.age = 40;
// user.email = "mona@gmail.com"
// console.log(Object.isFrozen(user));

// ==========================================


// const x ; inital value xxxx



// ===========================================

// global scope
// var x = 1;
// let y = 2;
// const z = 3;


// console.log(x, y,z);

// function test(){

//     console.log(x , y,z);
    
// }

// test();
// if(true){
//     console.log(x , y ,z);
    
// }


// ======================================

// function scope


// function scopeExample(){
//     var x = 1;
//     let y = 2;
//     const z = 3;

//     if(true){
//          console.log(x , y ,z);
//     }
// }

// scopeExample()
// console.log(x );
// console.log(y);
// console.log(z );

// ======================================

// Block scope


// if(true){

//     var x = 1;
//     let y = 2;
//     const z = 3;
// }

// console.log(z);

// ========================================================


// let x = 1;
// // console.log(x);  1
// function scopeExample(){
//     // console.log(x); 1
//     const y = 5;
//     // console.log(y); 5

//     if(true){
//         var z = 3;
//         let a = 4;
//         // console.log(x); 1
//         // console.log(y); 5
//     }

//     // console.log(z); 3
// }

// scopeExample();
// // console.log(y); error

// // console.log(z); error


// =============================================================


// Output : 3 3 3
// for(var i = 0; i< 3 ; i++){
//     setTimeout( function(){
//         console.log(i);
//     }, 1000)
// }

// ==============================================

// sync code
// const p = document.getElementById("myP");
// p.innerHTML = ""


// ========================================


// console.log("First");
// async code
// setTimeout(function(){
//     console.log("Second");
    
// },0)

// console.log("Last");


// =======================================

// Parsing fail
// console.log("Fist");
// let x = ; //syntax error
// console.log("Second");



// =======================================

// console.log("Fist");
// const x = 1;
// x = 3; runtime error
// console.log("Second");

// =========================================
// var x = 1;
// function first(){
//     const y = 10;
//     return y + 5;
// }
// console.log("First");
// setTimeout(function(){
//     console.log("Second");
    
// },0)
// console.log("Last");
// let result = first()

// ======================================
// create request
// ......
// request.addEvenetListener("load", function(){

        // data
        // create request 2
// })

// ==========================================


// setTimeout(function(){
//     console.log("2 seconds");
//         setTimeout(function(){
//         console.log("1 second");
//     },1000)
// },2000)


// setTimeout(function(){
//     //    opacity
//     setTimeout(function(){
//        //display
//     },500)
// },2000)
// ==========================================================
 
// var i ;
// for(var i = 0; i< 3 ; i++){
//     setTimeout( function(){
//         console.log(i);
//     }, 1000)
// }

// ================================================
// for(let i = 0; i< 3 ; i++){
//     setTimeout( function(){
//         console.log(i);
//     }, 1000)
// }


// ======================= hoisting =======================



// console.log(x);
// var x = 1;


// TDZ : Temporal Dead Zone
// function test(){
//     console.log(x);
//     let x = 1;
// }
// test();

// var x = 1;
// let y = 2;
// const z = 3;
// console.log(window.x);
// console.log(window.y);
// console.log(window.z);


// ======================================================

// modern best practice : prefer const by default


// ======================================================

// Spread Operator

// const arr = [2,4,6,8];
// const arr2 = arr;

// arr2[0] = 30;
// arr2.push(60)
// console.log(arr,arr2);


// const arr = [2,3,4,5,6];

// const arr2 = [];

// for(let i =0; i< arr.length; i++){
//     arr2.push(arr[i])
// }

// // console.log(arr2);
// arr2.push(90);

// console.log(arr , arr2);



// const arr = [2,3,4,5,6];
// const arr2 = arr.slice();

// arr2[0] = 55;
// console.log(arr , arr2);

// ==================================

// Spread Operator(...)


// const arr = [1,2,3,4];

// console.log(1,2,3,4);

// console.log(...arr); //1,2,3,4

// const arr = [1,2,3,4];
// const arr2 = [...arr]
// arr2.push(33);
// console.log(arr ,arr2);

// =============================================

// const arr = [1,2,3,[4,5]]

// const arr2 = [...arr];
// arr2.push(10)

// // console.log(arr2[3]);
// arr2[3].push(55);

// console.log(arr,arr2);

// =============================================================

// const arr = [1,2,3,[4,5], {fname:"mona"}];
// const arr2= structuredClone(arr)

// arr2[4].fname = "omar"

//  console.log(arr , arr2);
 
// =============================================================


// const arr = [1,2,3,[4,5]];

// const arr2 = JSON.parse(JSON.stringify(arr));
// arr2[3][0] = 44

// console.log(arr);
// console.log(arr2);

// ==============================================================


// spread operator use cases

// 1- shallow copy
// concating arrays

// const arr1 = [1,2,3,4];
// const arr2 = [5,6];
// const arr3 = [7,8];

// const combined = arr1.concat(arr2 , arr3);
// console.log(combined);

// const combined = [...arr1 , ...arr2 , ...arr3];
// console.log(combined);




// const arr = [2,3,4];

// console.log( [1,...arr]);
// console.log([...arr , 9]);
// console.log([0 , ...arr , 3, 10]);


// const arr = [1,2,3,4,5];

// console.log([  ...arr.slice(0,2) , 33 , ...arr.slice(2)  ]);

// =========================================================

// const divs = document.querySelectorAll("div");

// console.log([...divs]);

// const divs2 = document.getElementsByClassName("div")

// console.log([...divs2]);

// ====================================================


// const str = "hello";
// console.log([...str]);



// ========================================================


// const user = {
//     name : "mona",
//     age : 30,
//     address:{
//         city: "cairo"
//     }

// }


// const copy = {...user}

// copy.address.city = "alex"
// console.log(user);

// console.log(copy);

// ===================================================


// const obj1 = {a : 1}
// const obj2 = {b : 2}

// console.log({...obj1 , ...obj2 , c :3 , a:3});

// ==================================================

// const arr = [1,2,3]

// function sum(a,b,c){
//     return a+b+c;
// }
// console.log(sum(arr[0] , arr[1] , arr[2]));
// console.log(sum(...arr));


// const arr = [1,2,3,4,5,6]
// console.log(Math.max(...arr));

// ===============================================================

// Rest paramater (...)


// function sum(a,b,...rest){
//     // console.log(arguments);
    

//     console.log(rest);
    
// }

// sum(1,2,3,4,5,6)


// function inValid(...rest,a,b){
//     // console.log(arguments);
//     console.log(rest);
// }
// sum(1,2,3,4,5,6)



// function inValid(...rest,...rest2){
//     // console.log(arguments);
//     console.log(rest);
// }
// sum(1,2,3,4,5,6)

// ==================================

// function test(x , ...numbers){
//     console.log(x );
//     console.log(numbers);
// }
// // test(1)
// // test()

// test(2,3,4)

// ==================================


// Destructuring


// const arr = ["red", "green", "blue"];

// const first = arr[0];
// const second = arr[1];
// const third = arr[2];
// console.log(first , second , third);

// =====================================================
// const arr = ["red", "green", "blue"];

// const [first , second , third] = arr;
// console.log(first);
// console.log(second);
// console.log(third);


// const str = 'abc';
// const [a ,b,c] = str;

// console.log(a);
// console.log(b);
// console.log(c);


// skip elements
// const [first,,third,,fifth] = [1,2,3,4,5,6];
// console.log(first);
// console.log(third);
// console.log(fifth);


// const [ , , ...rest] = [1,2,3,4,5,6];

// console.log(rest);


// const [a,b,c = 0] = [1,2]
// console.log(a);
// console.log(b);
// console.log(c);


// const [x =10, y = 10] = [undefined , null]
// console.log(x);
// console.log(y);


// const [...all] = [1,2,3,4,5]; //shallow copy

// ====================================================

// let x = 10;
// let y = 20;
//   [x,y] = [y , x];

//   console.log(x , y);
  
// ==================================================

// const nested = [1,[2,3] , 4];
// const [a,[b , x],c] = nested;

// console.log(a);
// // [b ]= [2,3]
// console.log(b);
// console.log(x);

// console.log(c);



// const deep = [1,[2,[3,[4,5]]]];

// const [, [, [ , [x,y]]]] = deep

// console.log(x );
// console.log(y);



// const [first , [second , ...innerRest] , last] = [1,[2,3,4],5]
// console.log(innerRest);



// function mixedValues(x){
//     return [1,undefined , ['a','b'], 
//     function(){console.log("Hello");},x]
// }


// const [,x=10 , [y] ,z , data] = mixedValues(30);

// ===========================================


// Object destructuring

// const user = {
//     name: "omar",
//     age: 30,
//     email:"omar@gmail.com"
// }

// const {name , age } = user
// console.log(name);
// console.log(age);

// const {name:userName , age:userAge } = user
// console.log(userAge);


// const user = {
//     name: "omar",
//     age: 30,
//     email:"omar@gmail.com",
//     a : undefined
// };

// const {name:userName = 'Anonymous' , city:userCity='unkwnow' , a =0} = user;

// console.log(userName);
// console.log(userCity);
// console.log(a);


// ==========================================================



// const user = {
//     id:1,
//     name:"omar",
//     email:"omar@gmail.com",
//     age:30,
//     address:{
//         city:"cairo",
//         country:"Egypt"
//     }
// }


// const {id , name:userName , ...obj} = user

// console.log(obj);


// const user = {
//     id:1,
//     name:"omar",
//     email:"omar@gmail.com",
//     age:30,
//     address:{
//         city:"cairo",
//         country:"Egypt"
//     }
// }
// const {id , address, address:{country:userCountry =''}} = user

// console.log(address);


// ================================================


// const user = {
//     name:"mona",
//     address:{
//         city:"cairo",
//         country:"Egypt",
//         coordinates : {
//                 lat : 40.7134,
//                 lng: -30.123
//             }
//     }
    
// }

// const {name , address:{city, coordinates:{lat:latitude}} } = user;
// console.log(city);
// console.log(latitude);



//  [x , y] = [ y , x]

// let name = "mona";


// // let  {name} = {name: "omar"}

// ({name} = {name:"omar"})

// console.log(name);


// =====================================

// const users = [
//     {id:1,name:"mona", age:20},
//     {id:2,name:"mona", age:20}
// ] 


// for( const {id}  of users  ){
//     console.log(id);
    
// }

// =================================================


// Template literal (backticks)


// const name = "mona";
// const age = 30;
// console.log("My name is "+ name +" and i am "+ age + ' years old');

// console.log(`My name is ${name} and i am ${age} years old`);


// const old = 'line 1 \n'+
//             'line 2 \n';

// console.log(old);
 

// const multiLines = `
// line 1
// line 2
// line 3
// `

// console.log(multiLines);


// =======================================================

// Arrow Function


// function add(a , b){
//     return a + b;
// }

// const add2 = function(a,b){
//     return a+ b;
// }

// arrow function (full syntax)
// const add = (a,b)=>{
//     return a+b;
// }

// console.log(add(1,2));

// const add = (a,b)=>  a+b;
// const add = (a,b)=> console.log(a+b);
// const add = (a,b)=>{
//     console.log(a +b);
//     return a+b;
// }
// const square = (x)=>  x *x;
// const square = x=>  x *x;
// console.log(square(2));
// const greet = ()=> console.log("Hello")



// const makeUser = (name = '' , age =20) =>  ({name:name , age : age})

// console.log(makeUser("mona", 30));
// console.log(makeUser());


// ==========================================================

// Differences
// 1- arguments



// function regular (){
//     console.log(arguments);
    
// }

// regular(1,2,3,4,5)


// const arrow = ()=>{
//    console.log(arguments);
// }
// arrow(1,2,3,4,5)



// function outer(){
//     console.log(arguments);
//     function regular(){
//         console.log(arguments);
//     }
//     const arrow = ()=>{
//         console.log(arguments);
//     }
//     regular(1,2);
//     arrow(3,4)
// }
// outer('a' ,'b', 'c')

// ==========================================================



// var fname = "omar";
// var lname = "ahmed"


// const user = {
//     fname : "mona",
//     lname : "mohamed",
//     fullName : this.fname + ' ' + this.lname,

// }


// console.log(user);


// var fname = "ahmed"

// const user = {
//     fname: "mona",
//     lname : "mohamed",
    
//     greet: function(){
//         console.log(this.fname);
//     },
//     greet2 : ()=>{
//         console.log(this.fname);
//     }
// }

// // user.greet()

// user.greet2()

// =======================================




// var counter = 10;
// const obj = {
//     counter: 1,
//     startCounting:function(){
//         // console.log(this);
//         setInterval(function(){
//             // console.log(this);
//                 console.log(++this.counter);
//             }, 1000)
//     }
// }

// obj.startCounting()

// var counter = 10;
// const obj = {
//     counter: 1,
//     startCounting:function(){
//         // console.log(this);
//         setInterval(function(){
//             // console.log(this);
//                 console.log(++this.counter);
//             }.bind(this), 1000)
//     }
// }

// obj.startCounting();


// var counter = 10;
// const obj = {
//     counter: 1,
//     startCounting:function(){
//         let self = this;
//         setInterval(function(){
//                 console.log(++self.counter);
//             }, 1000)
//     }
// }

// obj.startCounting();

// ==============================================

// var counter = 10;
// const obj = {
//     counter: 1,
//     startCounting:function(){
//         setInterval(()=>{
//                 console.log(++this.counter);
//             }, 1000)
//     }
// }

// obj.startCounting();


// const user = {
//     fname: "mona",
//     greet:()=>{ 
//         console.log(this.fname); xxxxxxxxxx
        
//     }
// }


// ===========================================

// nullish coalesing operator (??)


// function add(a , b){

//     a = a || 0

// }

// add()
// add(2,3)


// =====================================



// let a = '';
// console.log(a || 1);
// console.log(a ?? 1);


// ========================================================


// Optional Chainging (?)

// const user = {
//     fname :"mona",
//     address:{
//         city:"cairo"
//     },
//     greet: function(){
//         console.log(this.fname);
        
//     }
// }

// console.log(user.address?.city);

// console.log(user.greet?.());

// =============================================================



// Array API 

/**
 * 
 * Filter
 * map
 * reduce (self study)
 * every
 * some
 * find
 * findIndex
 * flat
 * flatMap (self study)
 * 
 */


// function myFilter(arr, callBack){
//     const result = [] 
//     for(let i =0; i< arr.length ;i++){

//         if(callBack(arr[i],i,arr)){
//             result.push(arr[i])
//         }
//     }
//     return result 
// }

// const evens =  myFilter([1,2,3,4,5,6,7,8], function(num){

//     if(num % 2 === 0)
//         return true;
//     else
//         return false


// })


// const evens =  myFilter([1,2,3,4,5,6,7,8], function(num){

//     return num % 2 === 0


// })
// console.log(evens);


// const evens =  myFilter([1,2,3,4,5,6,7,8], (num)=> num % 2 ===0 )
// console.log(evens);


// ===========================================



// const users = [
//     {id :1 , name : "mona" , isActive : true},
//     {id :2 , name : "omar" , isActive : false},
//     {id :3 , name : "ahmed" , isActive : true},
// ]

// const activeUser =  users.filter(function(user){

//     return user.isActive
// })

// console.log(activeUser);

// const activeUser =  users.filter((user)=> user.isActive)
// const activeUser =  users.filter(( {isActive})=> isActive)
// console.log(activeUser);


// =====================================================



// const arr = [1,2,3,4,5,6];

// const result = arr.forEach(function(num){
//     console.log(num);
// })
// console.log(result);



// map : tranformation

// const employess = [
//     {id: 1 , name:"omar", salary:1000},
//     {id: 2 , name:"mona", salary:2000},
//     {id: 3 , name:"mohamed", salary:3000},
// ]

// const result = employess.map(function(emp){
//     emp.salary *= 1.5;
//     return emp

// })


// console.log(result);


// =============================================

// const arr = [-2,-3, -1];
// console.log(arr.every((num)=> num >0 ));
// console.log(arr.some((num)=> num >0 ));

// =============================================

// const arr = [1,2,6,3,5,4,5];


// console.log(arr.find((num)=> num > 4 ));
// console.log(arr.findIndex((num)=> num > 4 ));
// ===========================================

// const arr = [1,3,[4,5], [6,7, [10,11]]];

// console.log(arr.flat());

