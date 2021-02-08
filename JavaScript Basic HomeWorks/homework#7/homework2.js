let book = {
    title: prompt("Enter the name of book"),
    author: prompt("Enter the author of book"),
    readingStatus: prompt("Have you read the book you entered?" ,"Enter true or false"),
    printReadingStatus : function(){
        if(this.readingStatus === "true"){
            alert(`You have already really read the book ${this.title} by ${this.author}!`);
            return;
        }
        else(this.readingStatus === "false")
            alert(`You need to read the book ${this.title} by ${this.author}`);
        
        
        }
    }

book.printReadingStatus();