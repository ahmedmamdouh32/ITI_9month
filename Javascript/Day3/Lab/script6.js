var library = {
    books :[
        {
            title : "Head First C#",
            author : "Andor Stellman",
            year : 2021
        }

        ,

        {
            title : "Head 2 First C#",
            author : "Andor Stellman",
            year : 2021
        }

        ,

        {
            title : "Head 3 First C#",
            author : "Andor Stellman",
            year : 2021
        }
    ]
}

function logBooksTitles(obj){
    var booksTitles = []
    for(var book of obj[Object.keys(obj)[0]]){
        booksTitles.push(book.title);
    }
    return booksTitles
}

console.log(logBooksTitles(library))

