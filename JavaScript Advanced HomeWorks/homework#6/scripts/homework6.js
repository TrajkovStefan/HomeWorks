//TASK 1
let library = {
    name: "Boston Public Library",
    books: ["JavaScriptAdvanced", "JavaScriptBasic", "C#", ".Net", "Java"],
    address: "Las Vegas",
    numberOfMembers: function(){
       return this.books.length * 15;
    },
    printBooks: function(){
        Object.values(this.books).forEach(book => console.log(book));
    }
}

let book = {
    title: "Last chance",
    genre: "romance",
    libraries: ["Bodleian Library", "Vatican Library", "Boston Public Library", "Thomas Fisher"],
    authors: ["William Shakespeare", "Harold Robbins", "Dean Koontz", "Paulo Coelho"],
    addLibrary: function(){
        return library.books.push(this.title);
    },
    removeLibrary: function(){
        return library.books.pop(this.title);
    }
}

let author = {
    firstName: "William",
    lastName: "Shakespeare",
    yearOfBirth: 1970,
    books: [],
    currentBook: null,
    startBook: function(newBook){
        if(this.currentBook === null || undefined){
            return this.books.push(book.title);
        }
        else{
            
            return (this.books.push(this.currentBook) && (this.currentBook = newBook));
        }
    },
}

console.log("===All books of object library===");
library.printBooks();

//TASK 2
console.log("===TASK 2===");

//addLibrary()
book.addLibrary();
console.log(library.books);

//removeLibrary()
book.removeLibrary();
console.log(library.books);

//startBook();
author.startBook(book.title);
console.log(author.books);
console.log(author.currentBook);

//TASK3 
console.log("===TASK 3===");

let newBook = Object.create(library);
newBook.addBook = function(){
    return this.books.push(book.title);
}

newBook.addBook();
console.log(newBook.books);
console.log(library.books);




