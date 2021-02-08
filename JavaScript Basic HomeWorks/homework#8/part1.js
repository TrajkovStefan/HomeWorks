$(document).ready(function(){

    function printName(){
        let input = $("input").val();
        let firstName = input;
        button.after(`<h1></h1>`);
        $("h1:first").text(`Hello there ${firstName}`)
    }
    
    let button = $("button");

    button.click(printName);

});