function Library(name,books,address){
    this.name = name;
    this.books = books;
    this.address = address;
    this.numberOfMembers = this.books.length * 15;
    this.printBooks = function(){
        if(this.books.length == 0){
            console.log("There are no books!!!");
            return;
        }
        if(this.books.length > 0){
           return this.books.forEach(book => console.log(book.title));
        }
    }
}

function Book(title,genre,libraries,authors){
    this.title = title;
    this.genre = genre;
    this.libraries = libraries;
    this.authors = authors;
    this.addLibrary = function(someLibrary){
       someLibrary.books.push(this);
    }
    this.removeLibrary = function(someLibrary){
       someLibrary.books.pop(this);
    }
}

function Author(firstName,lastName,YearOfBirth){
    this.firstName = firstName;
    this.lastName = lastName;
    this.YearOfBirth = YearOfBirth;
    this.books = [];
    this.currentBook = null;
    this.startBook = function(someBook){
      this.currentBook = someBook;
      this.books.push(this.currentBook);
    }
}
let author = new Author("Wiliam", "Shakespeare", 1970);
let book = new Book("Python", "programming", ["Boston Public Library", "Vatican Library"], [author]);
let bookSecond = new Book("CSS", "programming", ["Boston Public Library", "Vatican Library"], [author]);
let library = new Library("Boston Public Library", [], "Las Vegas");


//Add Book
book.addLibrary(library);
//Pint All Books
library.printBooks(book);
console.log(library);

//Remove Book
book.removeLibrary(library);
//Print All Books
library.printBooks(book);


author.startBook(book);
author.startBook(bookSecond);
console.log(author);


let anotherLibrary = Object.create(library);
anotherLibrary.addBook = function(){
    this.books.push(book);
}

anotherLibrary.addBook();

