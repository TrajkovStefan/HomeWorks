$("button").click(function(){
    if($("input").val() === ""){
        console.log("Enter the value");
    }
    else{
        $("select").after($("input").val());
    }
    $("input").blur(function(){
        if($("input").val() === ""){
            console.log("Value is entered");
        }
        else{
            console.log("Enter the value");
        }
        
    })
})


//NEDOVRSENA