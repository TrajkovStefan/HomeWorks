function Library(name,books,address){
    this.name = name;
    this.books = books;
    this.address = address;
    this.numberOfMembers = this.books.length * 15;
    this.printBooks = function(){
       this.books.forEach(book => console.log(book.title));
    }
}

function Book(title,genre,libraries,authors){
    this.title = title;
    this.genre = genre;
    this.libraries = libraries;
    this.authors = authors;
    this.addLibrary = function(someBook){
       someBook.books.push(this)
    }
    this.removeLibrary = function(someBook){
       someBook.books.pop(this);
    }
}

function Author(firstName,lastName,YearOfBirth){
    this.firstName = firstName;
    this.lastName = lastName;
    this.YearOfBirth = YearOfBirth;
    this.books = [];
    this.currentBook = null;
    this.startBook = function(someBook){
        this.books.push(someBook); // Book added to the Author property Books
        if(this.currentBook !== someBook){ // if was another book in the currentBook
            this.books.push(this.currentBook); // book transfered to books
        }
        else{
            this.currentBook = someBook; //then add newBook as currentBook
        }
    }
}

let author = new Author("Wiliam", "Shakespeare", 1970);
let book = new Book("Python", "programming", ["Boston Public Library", "Vatican Library"], [author]);
let library = new Library("Boston Public Library", [], "Las Vegas");


//Add Book
book.addLibrary(library);
//Pint All Books
library.printBooks(book);

//Remove Book
book.removeLibrary(library);
//Print All Books
library.printBooks(book);


author.startBook(book);
console.log(author.books);
console.log(author.currentBook);

