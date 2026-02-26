/**
 * 
 *  Set , Map
 *  Object.keys()
 *  Object.values()
 *  Object.entries()
 *  Object.fromEntries()
 *  Object.assign()
 *  for..of , for..in
 *  promise --> fetch , async/await
 * 
 */

// ==============================================


// Set : Collection of unique value.

// Creating set

// const set = new Set();
// console.log(set);

// const set = new Set([1,2,3,4,4,5,6,2,3]);

// console.log(set);


// const set = new Set("Hello");
// console.log(set);


// const set = new Set([ 1 , '1' , true , null , undefined , NaN , NaN])

// console.log(set);


// const set = new Set([1,2,3,4]);

// console.log(set.has(2));
// console.log(set.has(5));


// const set = new Set([1,2,3,4]);

// console.log(set.add(50));

// set.add(50)
// set.add(60)
// set.add(70)

// set.add(50).add(60).add(70)
// console.log(set);


// const set = new Set([1,2,3,4]);
// console.log(set.delete(10));
// console.log(set);

// const set = new Set([1,2,3,4]);
// set.clear();
// console.log(set);

// const set = new Set([1,2,3,4,11]);

// console.log(set.size);

// ==============================================

// const arr = ['banana' , 'orange' , 'apple', 'orange'];
// const uniqueItems = [...new Set(arr)];


// ==============================================


// union : all elements from both sets

// const setA = new Set([1,2,3])
// const setB = new Set([3 ,4,5]);

// const merged = setA.union(setB);
// console.log(merged);


// const setA = new Set([1,2,3])
// const setB = new Set([3 ,4,5]);

// console.log(  [...new Set([...setA , ...setB] )]);
// ==============================================


// intersection : elements in both sets


// const setA = new Set([1,2,3])
// const setB = new Set([3 ,4,5]);
// console.log(setA.intersection(setB));

// ==============================================


// difference
// const setA = new Set([1,2,3])
// const setB = new Set([3 ,4,5]);

// console.log(setA.difference(setB));
// console.log(setB.difference(setA));

// symmeticDifference

// const setA = new Set([1,2,3])
// const setB = new Set([3 ,4,5]);

// console.log(setA.difference(setB));
// console.log(setB.difference(setA));

// console.log(setA.symmetricDifference(setB));


// const setB = new Set([3 ,4,5]);

// for(const value  of setB){
//     console.log(value);
    
// }

// =============================================


// map : collection of key-value pairs where keys can be any type 


// entries : array of [key , value]  --> [[key,value] , [key,value],..]
// const map = new Map([ ["name" , "mona"] , [true , 'value2'] , [{id:1}   , 'object']  ]);
// console.log(map);

// console.log(map.get("name"));
// console.log(map.get("true"));
// console.log(map.get(true));



// ====================================
// const user = {
//     name : "omar"
// }

// user[true] = 1
// user["true"] = 40

// console.log(user);

// console.log(user[true]);
// console.log(user["true"]);

// ========================================

// const map = new Map([ ["name" , "mona"] , [true , 'value2'] , [{id:1}   , 'object']  ]);

// map.set("true" , 'value3');

// console.log(map);

// const obj = {id:1};
// const map = new Map([ ["name" , "mona"] , [true , 'value2'] , [ obj  , 'object']  ]);

// // console.log(map.get({id : 1}));xxx
// console.log(map.get(obj));

// set , get ,size , delete , clear , has

// ================================================
// const obj = {id:1};
// const map = new Map([ ["name" , "mona"] , [true , 'value2'] , [ obj  , 'object']  ]);

// for(const [key , value]  of map){
//     // console.log(item[0] , item[1]);
//     console.log(key , value);
// }


// ================================================
// map --> array

// const obj = {id:1};
// const map = new Map([ ["name" , "mona"] , [true , 'value2'] , [ obj  , 'object']  ]);
// console.log([...map].flat());

// ==============================================

// new syntax

// const name = "omar";
// const age = 30;

// const user = {
//     name : name,
//     age : age
// }

// prop shorthand
// const user = {
//     name , //name : name
//     age 
// }


// console.log(user);


// ==============================================


// const key = "name"
// const user = {
//     key : "omar"
// }
// console.log(user);


// const user = {
//     name : "omar"
// }
// const key = "name";

// console.log(user.key);
// console.log(user[key]);

// =======================================



// const key = "name";
// const user = {
//     // computed prop name
//     [key] : "omar"
// }

// console.log(user);

// const prefix = "user";
// const user = {
//     [prefix + "Id"] : 1,
//     [prefix + "Name"] : "mona"
// }
// console.log(user);

// ===============================================


// const user = {
//     // greet : function(){
//     //     console.log("Hello");
        
//     // }

//     // method shorthand
//     greet(){

//     },
//     greet2: ()=>{

//     }
// }

// ==================================================

// Object.keys() : [key1, key2 ,...]

// const arr = ["mona" , "ali","omar"];
// console.log(Object.keys(arr))


// const user = {
//     name : "omar",
//     age:30
// }

// const keys = Object.keys(user); //['name' ,'age']

// for(let i =0; i < keys.length ; i++){
//     console.log(user[keys[i]]);
// }

// console.log(keys.length);
// console.log(keys.length === 0);

// =======================================

// const user = {
//     name : "omar",
//     age:30
// }

// console.log(Object.values(user)); //['omar' , 30]

// ==================================================
// const prices = {
//     apple : 50,
//     banana : 20,
//     orange : 10
// }
// console.log(Math.max( ...Object.values(prices)));



// =================================


// const stock = {
//     phone : 10,
//     laptop: 5,
//     smartWatch : 0,
//     airpods : 0
// }

//  const inStock =Object.values(stock).filter(count => count > 0)
//  console.log(inStock);

// =============================================

// const user = {
//     name : "omar",
//     age: 20,
//     email: "omar@gmail.com"
// }
// console.log(Object.entries(user));

// for(const [key , value]  of  Object.entries(user)){
//     console.log(key , value);
// }
                                                            // key : key , value: value
// const result = Object.entries(user).map( ([key ,value]) => ({[key] : value}))
//  [ {name :"mona"} , {age : 20}]
// console.log(result);

// ====================================================


// object ---> map
// const user ={
//     name : "omar",
//     age: 20,
//     email: "omar@gmail.com"
// }

// console.log(Object.entries(user));

// console.log(new Map(Object.entries(user)));

// ============================================


// map --> object
// Object.fromEntries()

// const entries = [  ['name', 'mona'] ,['age', 30] ,[ true ,'value3'] ]

// console.log(Object.fromEntries(entries));

// map --> object

// const map = new Map([  ['name', 'mona'] ,['age', 30] ,[ true ,'value3'] ])
// console.log(Object.fromEntries([...map]));

// =================================================


// Object.assign() : copy and merge objects

// const obj1 = {a :1 , b:2}
// const obj2 = {c:3 , b: 30}
// const obj3 = {d :5}
// console.log({ ...obj1 , ...obj2 , ...obj3 , a:40});

// Object.assign(target , source1 , source2 ,...)

// console.log(Object.assign(obj1 , obj2 , obj3));
// console.log(Object.assign( {},obj1 , obj2 , obj3));
// console.log(obj1);


// ==============================================


// function setUserSettings (theme='light' , language = 'en' , notification = false ){

//     return {theme : theme , language , notification}
// }


// console.log(setUserSettings("dark" , "en" , true));
// console.log(setUserSettings());


// function setUserSettings ( settings ){
//     const defaultSettings = {theme :"light",language : "en" , notifications: false}
    
//     return Object.assign({} , defaultSettings , settings )
// }

// // console.log(setUserSettings({ theme : "dark", langage : "en" , notifications: true }));
// // console.log(setUserSettings());

// console.log(setUserSettings({theme:"dark"}));
// console.log(setUserSettings({theme:"dark" , language : "ar"}));


// function setUserSettings ( {theme ='light' , language='en', notifications =false} ){
    
//     return {theme , language , notifications}
// }


// console.log(setUserSettings({theme:"dark"}));
// console.log(setUserSettings({theme:"dark" , language : "ar"}));


// ==================================================

// for .. of   vs for..in

// const arr = ["mona" , "ola", "ahmed"]

// for( const value of arr){
//     console.log(value);
    
// }
// 
// for( const item  in arr  ){
//     console.log(item);
// }


// const user  = {
//     name : "mona",
//     age : 30
// }

// for (const item of user){
//     console.log(item);
// }

// for(const key in user){
//     console.log(key , user[key]);
// }

// ============================================



// Example 1
// start end outer  after-inner-timer  inner
// console.log("start")
// setTimeout( function(){
//     console.log("outer");
//     setTimeout( function(){
//         console.log("inner");
//     }, 0)
//     console.log("After inner timer");
// }, 0)
// console.log("end");


// Example 2

// setTimeout( function(){
//     console.log("Timer");
// } , 0)
// function heavyTask(){
//     const start = Date.now();
//     while(  Date.now()- start < 3000){}
//     console.log("Heavy task Done");
// }
// heavyTask();
// console.log("After heavy task");


// ==========================================


// setTimeout(function(){
//     console.log("first");
    
// } ,1000)
// setTimeout(function(){
//     console.log("second");
// } ,500)
// setTimeout(function(){
//     console.log("third");
// } ,0)
// console.log("Fourth");


// setTimeout(function(){
//     console.log("first");
//     setTimeout(function(){
//         console.log("second");
//         setTimeout(function(){
//              console.log("third");
//      } ,0)
//     } ,500)
// } ,1000)

// console.log("Fourth");

// ===========================================
//  const [countryContaier] = document.getElementsByClassName("country__container");


// function renderCountry(country){
//      //    console.log(country);
//        const [language] = Object.values(country.languages)
//        const currency = Object.values(country.currencies)[0].symbol;

//        const html = `
//                 <section class="country">
//                 <img class="country__img" src="${country.flags.png}" />
//                 <div class="country__data">
//                     <h3 class="country__name">${country.name.common}</h3>
//                     <h4 class="country__region">${country.region}</h4>
//                     <p class="country__row"><span>👫</span>${country.population}</p>
//                     <p class="country__row"><span>🗣️</span>${language}</p>
//                     <p class="country__row"><span>💰</span>${currency}</p>
//                 </div>
//              </section>
//        `

//        countryContaier.insertAdjacentHTML('beforeend', html)

//        countryContaier.style.opacity = 1
// }

// function renderCapital(capitalWeather){
    
//                     const {current_weather:{temperature , weathercode :weatherCode , windspeed} ,
//                         current_weather_units : {temperature : temperatureUnit, windspeed:windspeedUnit} } = capitalWeather
                    
//                         console.log(temperature , weatherCode , windspeed , temperatureUnit , windspeedUnit);
                        
                    
//                         let icon , desc , styleClass;
//                     if (weatherCode === 0) {
//                         icon = '☀️'; desc = 'Clear Sky'; styleClass = 'weather--sunny';
//                     } else if (weatherCode <= 3) {
//                         icon = '🌤️'; desc = 'Partly Cloudy'; styleClass = '';
//                     } else if (weatherCode >= 51 && weatherCode <= 67) {
//                         icon = '🌧️'; desc = 'Rainy'; styleClass = '';
//                     } else if (weatherCode >= 71 && weatherCode <= 77) {
//                         icon = '❄️'; desc = 'Snowy'; styleClass = '';
//                     } else {
//                         icon = '☁️'; desc = 'Cloudy'; styleClass = '';
//                     }
                    
//                     const html2 = `
                    
//                             <section class="country weather ${styleClass} ">
//                             <div class="weather__icon-box">${icon}</div>
//                             <div class="country__data">
//                                 <h3 class="country__name">${desc}</h3>
//                                 <h4 class="country__region">Current Forecast</h4>
//                                 <p class="country__row"><span>🌡️</span>${temperature}${temperatureUnit}</p>
//                                 <p class="country__row"><span>💨</span>${windspeed}${windspeedUnit} </p>
//                             </div>
//                         </section>

//                     ` 

//                     countryContaier.insertAdjacentHTML("beforeend", html2)
// }
// // Get Country Data

// function getCountry(country){
//     const request = new  XMLHttpRequest();
//     request.open("GET" , `https://restcountries.com/v3.1/name/${country}`);
//     request.send();
//     request.addEventListener("load", function(){

//     if(request.status == 200){
//        const [country]=   JSON.parse(request.responseText);
//             renderCountry(country)
//             //   Capital weather
//            const [lat , lng] = country.capitalInfo.latlng
            
//             const request2 = new  XMLHttpRequest();
//             request2.open("GET" , `https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`);
//             request2.send();
            
//             request2.addEventListener("load" , function(){
//                 if(request2.status == 200){
//                     const capitalWeather = JSON.parse(request2.responseText);
//                     renderCapital(capitalWeather);
                    
//                 }
//             })
            
        
//     }
// })

// }

// getCountry("Egypt")

// Callback hell
// setTimeout(  function(){
//     console.log("1 second");
//     setTimeout(  function(){
//         console.log("2 second");
//         setTimeout(  function(){
//             console.log("3 second");
//             setTimeout(  function(){
//                 console.log("1 second");
//     } , 1000)
//     } , 1000)
//  } , 1000)

// } , 1000)

// ===============================================


// const [countryContaier] = document.getElementsByClassName("country__container");


// function renderCountry(country){
//      //    console.log(country);
//        const [language] = Object.values(country.languages)
//        const currency = Object.values(country.currencies)[0].symbol;

//        const html = `
//                 <section class="country">
//                 <img class="country__img" src="${country.flags.png}" />
//                 <div class="country__data">
//                     <h3 class="country__name">${country.name.common}</h3>
//                     <h4 class="country__region">${country.region}</h4>
//                     <p class="country__row"><span>👫</span>${country.population}</p>
//                     <p class="country__row"><span>🗣️</span>${language}</p>
//                     <p class="country__row"><span>💰</span>${currency}</p>
//                 </div>
//              </section>
//        `

//        countryContaier.insertAdjacentHTML('beforeend', html)

//        countryContaier.style.opacity = 1
// }

// function renderCapital(capitalWeather){
    
//                     const {current_weather:{temperature , weathercode :weatherCode , windspeed} ,
//                         current_weather_units : {temperature : temperatureUnit, windspeed:windspeedUnit} } = capitalWeather
                    
//                         console.log(temperature , weatherCode , windspeed , temperatureUnit , windspeedUnit);
                        
                    
//                         let icon , desc , styleClass;
//                     if (weatherCode === 0) {
//                         icon = '☀️'; desc = 'Clear Sky'; styleClass = 'weather--sunny';
//                     } else if (weatherCode <= 3) {
//                         icon = '🌤️'; desc = 'Partly Cloudy'; styleClass = '';
//                     } else if (weatherCode >= 51 && weatherCode <= 67) {
//                         icon = '🌧️'; desc = 'Rainy'; styleClass = '';
//                     } else if (weatherCode >= 71 && weatherCode <= 77) {
//                         icon = '❄️'; desc = 'Snowy'; styleClass = '';
//                     } else {
//                         icon = '☁️'; desc = 'Cloudy'; styleClass = '';
//                     }
                    
//                     const html2 = `
                    
//                             <section class="country weather ${styleClass} ">
//                             <div class="weather__icon-box">${icon}</div>
//                             <div class="country__data">
//                                 <h3 class="country__name">${desc}</h3>
//                                 <h4 class="country__region">Current Forecast</h4>
//                                 <p class="country__row"><span>🌡️</span>${temperature}${temperatureUnit}</p>
//                                 <p class="country__row"><span>💨</span>${windspeed}${windspeedUnit} </p>
//                             </div>
//                         </section>

//                     ` 

//                     countryContaier.insertAdjacentHTML("beforeend", html2)
// }
// // Get Country Data

// function getCountry(country){
//     const request = new  XMLHttpRequest();
//     request.open("GET" , `https://restcountries.com/v3.1/name/${country}`);
//     request.send();
//     request.addEventListener("load", function(){

//     if(request.status == 200){
//        const [country]=   JSON.parse(request.responseText);
//             renderCountry(country)
//             //   Capital weather
//            const [lat , lng] = country.capitalInfo.latlng
            
//             const request2 = new  XMLHttpRequest();
//             request2.open("GET" , `https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`);
//             request2.send();
            
//             request2.addEventListener("load" , function(){
//                 if(request2.status == 200){
//                     const capitalWeather = JSON.parse(request2.responseText);
//                     renderCapital(capitalWeather);
                    
//                 }
//             })
            
        
//     }
// })

// }


// const result= fetch('https://restcountries.com/v3.1/name/egypt')

// console.log(result);

// ============================================
// promise life cycle
/**
 *  1- pending
 * 
 *  2- settled
 *          -  fulfilled : success
 *          -  rejected  : error
 * 
 */
// =============================================
// Consuming promise



// set.add(20).add(30).add(40)
//  . . . . . . .


// ==============================================


// const [countryContaier] = document.getElementsByClassName("country__container");


// function renderCountry(country){
//      //    console.log(country);
//        const [language] = Object.values(country.languages)
//        const currency = Object.values(country.currencies)[0].symbol;

//        const html = `
//                 <section class="country">
//                 <img class="country__img" src="${country.flags.png}" />
//                 <div class="country__data">
//                     <h3 class="country__name">${country.name.common}</h3>
//                     <h4 class="country__region">${country.region}</h4>
//                     <p class="country__row"><span>👫</span>${country.population}</p>
//                     <p class="country__row"><span>🗣️</span>${language}</p>
//                     <p class="country__row"><span>💰</span>${currency}</p>
//                 </div>
//              </section>
//        `

//        countryContaier.insertAdjacentHTML('beforeend', html)

//        countryContaier.style.opacity = 1
// }

// function renderCapital(capitalWeather){
    
//                     const {current_weather:{temperature , weathercode :weatherCode , windspeed} ,
//                         current_weather_units : {temperature : temperatureUnit, windspeed:windspeedUnit} } = capitalWeather
                    
//                         console.log(temperature , weatherCode , windspeed , temperatureUnit , windspeedUnit);
                        
                    
//                         let icon , desc , styleClass;
//                     if (weatherCode === 0) {
//                         icon = '☀️'; desc = 'Clear Sky'; styleClass = 'weather--sunny';
//                     } else if (weatherCode <= 3) {
//                         icon = '🌤️'; desc = 'Partly Cloudy'; styleClass = '';
//                     } else if (weatherCode >= 51 && weatherCode <= 67) {
//                         icon = '🌧️'; desc = 'Rainy'; styleClass = '';
//                     } else if (weatherCode >= 71 && weatherCode <= 77) {
//                         icon = '❄️'; desc = 'Snowy'; styleClass = '';
//                     } else {
//                         icon = '☁️'; desc = 'Cloudy'; styleClass = '';
//                     }
                    
//                     const html2 = `
                    
//                             <section class="country weather ${styleClass} ">
//                             <div class="weather__icon-box">${icon}</div>
//                             <div class="country__data">
//                                 <h3 class="country__name">${desc}</h3>
//                                 <h4 class="country__region">Current Forecast</h4>
//                                 <p class="country__row"><span>🌡️</span>${temperature}${temperatureUnit}</p>
//                                 <p class="country__row"><span>💨</span>${windspeed}${windspeedUnit} </p>
//                             </div>
//                         </section>

//                     ` 

//                     countryContaier.insertAdjacentHTML("beforeend", html2)
// }

//   fetch('https://restcountries.com/v3.1/name/egypt')
//   .then(function(res){
//        return res.json()
//   }).then(function([country]){
//         renderCountry(country)
//         const [lat , lng] = country.capitalInfo.latlng
//         return fetch(`https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`)
//   }).then(function(res){
//        return res.json();
//   }).then(function(data){
    
//     renderCapital(data)

//   })
    

//   fetch('https://restcountries.com/v3.1/name/egypt')
//   .then(res =>res.json()).then(([country])=>{
//         renderCountry(country)
//         const [lat , lng] = country.capitalInfo.latlng
//         return fetch(`https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`)
//   }).then(res => res.json()).then(data=> renderCapital(data))

// ====================================================



//   fetch('https://restcountries.com/v3.1/name/egypt')
//   .then(res =>res.json(),err =>console.log(err)).
//   then(([country])=>{
//         renderCountry(country)
//         const [lat , lng] = country.capitalInfo.latlng
//         return fetch(`https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`)
//   }).then(res => res.json() ,err =>console.log(err) ).then(data=> renderCapital(data))


// const btn  = document.getElementById("btn");

// function getCountry(country){
    
//  fetch(`https://restcountries.com/v3.1/name/${country}`)
//   .then(res =>res.json()).
//   then(([country])=>{
//         renderCountry(country)
//         const [lat , lng] = country.capitalInfo.latlng
//         return fetch(`https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`)
//   }).then(res => res.json() )
//   .then(data=> renderCapital(data))
//   .catch(err => console.log(err))
// }

// btn.addEventListener("click", getCountry)

// getCountry("Egyptytyytytt")

// ================================================


// function getCountry(country){
    
//  fetch(`https://restcountries.com/v3.1/name/${country}`)
//   .then(res =>{
//     // res.json()
//     // console.log(res);
//     if(!res.ok)
//         throw new Error("Country Not found")
//     return res.json()

// })
//   .then(data =>renderCountry(data[0]))
//   .catch(err => console.log(`${err.message} ❌`))
//   .finally()
// }


// // getCountry("Egypttytyytt")

// getCountry("usa")

// =====================================================


// async /await

//   function getCountry(country){
    
//     // fetch(`https://restcountries.com/v3.1/name/${country}`)
//     // .then() //await
//     // .then() //await


//     await fetch(`https://restcountries.com/v3.1/name/${country}`)

// }

// top level await 

// await fetch(`https://restcountries.com/v3.1/name/${country}`)


// =================================================



// console.log("First");

//   async function getCountry(country){
//    try{
//         const res = await fetch(`https://restcountries.com/v3.1/name/${country}`)
//         if(!res.ok)
//             throw new Error("Country Not found")
//         const [data] =  await res.json() ;
//         renderCountry(data) 
//         const [lat , lng] = data.capitalInfo.latlng
//         const res2 =  await fetch(`https://api.open-meteo.com/v1/forecast?latitude=${lat}&longitude=${lng}&current_weather=true`)
//         if(!res2.ok)
//             throw new Error("Capital Not found")
//        const weartherData = await res2.json()
//        renderCapital(weartherData)
//    }catch(err){
//     console.log(`${err.message} ❌`);
//    }
// }

// getCountry("Egypt")


// =============================================================

// Creating promise


/***
 * 
 *  resolve = function(value){
 * 
 *      changeStateTo("fulfilled")
 *      passValueToThen(value)
 *  
 * }
 * 
 * reject = function(reason){
 *  changeStateTo("reject")
 *  passValueToCatch(reason)
 * }
 * 
 */



// const promise = new Promise(function(resolve , reject){
//    setTimeout(function(){
//          const success = true;
//     if(success){
//         resolve("it worked!"); //fulfiled
//     }
//     else{
//         reject("it fail!") //rejected
//     }
//    } , 1000)
// })


// // console.log(promise);
// promise.then(function(x){
//     console.log(x);
// })
// .catch(err => console.log(err)
// )

// ==========================================




// function myFetch(url){
//     return Promise((resolve , reject)=>{
//         const request = new XMLHttpRequest();
//         request.open("GET", url);
//         request.send();
//         request.onload = function(){
//             resolve(request.responseText);
//         }
//         request.onerror = function(){
//             reject(new Error("Network error"));
//         }
//     })
// }

// ===================================================








