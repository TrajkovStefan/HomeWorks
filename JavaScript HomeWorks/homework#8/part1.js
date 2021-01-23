$(document).ready(function(){

    function printName(){
        $("h1").text("");
        let input = $("input").val();
        let firstName = input;
        button.after(`<h1>Hello there ${firstName}</h1>`);
    }
    
    let button = $("button");

    button.click(printName);

});