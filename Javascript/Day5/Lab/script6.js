
var returnBackFlag = false;
var timeIntervalHandler;
var newWindowHandler;
var currentPositionHeight = 0;
console.log(typeof newWindowHandler);
function startMovement(){
    if(typeof newWindowHandler === 'undefined'){
        newWindowHandler = open("","_blank" ,"width=100px,height=100px"); 
        
    }
    timeIntervalHandler = setInterval(() => {

        if(currentPositionHeight<screen.height-newWindowHandler.innerWidth-60 && returnBackFlag == false){
            newWindowHandler.moveBy(4 ,4);
            currentPositionHeight+=4;
        }
        else{
            returnBackFlag = true;
        }

        if(currentPositionHeight>0 && returnBackFlag == true){
            newWindowHandler.moveBy(-4,-4);
            currentPositionHeight-=4;
        }
        else{
            returnBackFlag = false;
        }
    }, 10);
}


function stopMovement(){
    clearInterval(timeIntervalHandler);
}


