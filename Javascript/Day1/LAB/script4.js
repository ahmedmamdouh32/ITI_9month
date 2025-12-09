
for(;;){
    if(confirm("Do You Fly ?")){
        if(confirm("Are You Wild ?")){
            confirm("You are thinking of : Eagle")
        }
        else{
            confirm("You are thinking of : Parrot")
        }
    }
    else{
        if(confirm("Do You line Under Sea ?")){
            if(confirm("Are You Wild ?")){
                confirm("You are thinking of : Shark")
            }
            else{
                confirm("You are thinking of : Dolphin")
            }
        }
        else{
            if(confirm("Are You Wild ?")){
                confirm("You are thinking of : Lion")
            }
            else{
                confirm("You are thinking of : Cat")
            }
        }
    }
    if(confirm("Play Again ????")){
        continue;
    }
    else{
        break;
    }
}