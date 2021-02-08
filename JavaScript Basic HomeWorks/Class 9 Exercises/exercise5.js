let myInput = $("input");

$("input").blur(function(){
    if($("input").val() === ""){
        alert("Enter the value");
    }
    else{
        alert("Value is entered");
    }
    
})

$("button").click(function(){
    if($("input").val() === ""){
        console.log("Enter the value");
    }
    else{
        $("select").append(`<option></option>`);
        $("option:last").text(`${myInput.val()}`);
    }

   
})