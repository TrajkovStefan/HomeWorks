$(document).ready(function(){
    input1 = $("input:first");
    input2 = $("input:last");

    function changeColor(valueNumber,valueColor){
    if(valueNumber === ""){
        alert('Please enter your text and pick your favorite color');
    }
    
    else{
        button.after(`<h1></h1>`)
        $("h1:first").text(`${valueNumber}`).css("color", `${valueColor}`);  
    }

    }

    let button = $("button"); 
    button.click(function(){
        changeColor(input1.val(),input2.val());
    });
});

