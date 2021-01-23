$(document).ready(function(){

    function changeColor(){
    input1 = $("input:first").val();
    input2 = $("input:last").val();
    
    if(input1 === ""){
        alert('Please enter your text and pick your favorite color');
    }
    
    else{
        
        button.after(`<h1></h1>`)
        $("h1").text(`${input1}`).css("color", `${input2}`);  
    }

    }

    let button = $("button"); 
    button.click(changeColor);
});

