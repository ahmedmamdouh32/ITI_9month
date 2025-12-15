// console.log(window);

//  var myWin= open("","_blank" ,"width=200px,height=200px")

// var myWin;

//  function openWindow(){
//    myWin= open("https://www.google.com","_blank" ,"width=300px,height=300px")  
// //    myWin.document.writeln("New Tab")
//  }


//  function closeWindow()
//  {
//     myWin.close()
//  }


//  function MoveToWindow(){
//     myWin.moveTo(400,400)
//  }

//   function MoveByWindow(){
//     myWin.moveBy(300,300)
//  }
//  function resizeToWindow(){
//     myWin.resizeTo(100,100)
// }


//  function resizeByWindow(){
//     myWin.resizeBy(100,100)
// }



// function test(){
//     console.log("set Time Out Callbak fync");
// }



// function test2(){
//     // test()
//     console.log("test 2");
// }


// setTimeout(test2,3000)

// setTimeout(function(){
//     test()
//     test2()
// },3000)




// var myInterval = setInterval(test,2000)


// setTimeout(function(){
// clearInterval(myInterval)
    
// } ,5000)





// function sayHello(trackName , track){
//     console.log("Welcome "+trackName + track);
// }


// setTimeout(function(){
//     sayHello("PD")
// },2000)




// setTimeout(sayHello, 2000 , "PD" , "track3");

// var span = document.getElementById("result")
// var counter =0

// var myInterval;


// function start(){
//    myInterval= setInterval(function(){
//         span.innerHTML=++counter
//     },1000)

// }


// function end(){
//     clearInterval(myInterval)
// }


// var p2 = document.getElementById("result")

// function download(){
// p2.innerHTML ="Link will appear after 3 seconds"

// setTimeout(function(){
//     p2.innerHTML="<a href=''>Google</a>"
// },3000)
// }


// console.log(location)

// location.reload()


// setInterval(() => {
//     location.reload()
// }, 3000);

// location.assign() 
// location.replace()



// console.log(screen.width);
// console.log(screen.height);
// console.log(window.innerWidth);
// console.log(window.innerHeight);


// console.log(history)


// console.log(navigator)


// function success(P){
//     console.log(P.coords.latitude);

//        console.log(P.coords.longitude);
// }

// navigator.geolocation.getCurrentPosition(success , function(){
//     console.log("Deny");
// })





// var p = document.getElementById("p1")
// var btn = document.getElementById("result")

// btn.onclick = changeContent
// btn.onclick = changeStyle


// btn.onclick = function(){
//     changeContent()
//     changeStyle()
// }

// btn.onmouseenter = changeStyle
// p.style.backgroundColor ="red"


// btn.addEventListener("click" , changeContent)
// btn.addEventListener("click" , changeStyle)

// setTimeout(function(){
// btn.removeEventListener("click" , changeStyle)

// },3000)

// function changeContent(){
//     p.innerHTML ="Hello PD"

// }
// function changeStyle(){
//     p.style.color ="red"
//     // p.style.cssText ="color:red"
// }




// var input  = document.getElementById("input1")

// function changeBorder(){
//     input.style.border ="5px solid green"
// }

// function changeBorderWitnInput(){
// if(input.value.length >3){
//     input.style.border ="5px solid yellow"

// }
// else{
//      input.style.border ="5px solid red"

// }

// }
// input.addEventListener("focus" , changeBorder)
// input.addEventListener("input" , changeBorderWitnInput)





var p = document.getElementById("p1")
var btn = document.getElementById("result")


// btn.addEventListener("click" , changeContent)

function changeContent(e){
    console.log(e)
    p.innerHTML ="Hello PD"


}
function changeStyle(){
    p.style.color ="red"
    // p.style.cssText ="color:red"
}



var first =  document.getElementById("first")
var second = document.getElementById("second")
var third = document.getElementById("third")


//Propagation
var another = document.getElementById("another")

first.addEventListener("click" , function(e){
    console.log("first")
})

second.addEventListener("click" , function(e){
    // e.stopPropagation()
    console.log("second")
})

another.addEventListener("keydown" , 
    function(){
        console.log("another");
    }
)

third.addEventListener("click" , function(e){

    // e.stopPropagation()
    console.log("third")
})