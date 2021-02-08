let firstInput = $("input:first");
let secondInput = $("input:last");
let myButton = $("button");

myButton.click(function(){
    $("input").html("");
    $("#area").html("");
    if(firstInput.val() && secondInput.val() === ""){
        alert("Enter the sides of rectangle");
    }
    else{
        let perimeter = 0;
        perimeter = 2*(firstInput.val() + secondInput.val()); 
        myButton.after(`<p id="perimetar">${perimeter}</p>`);
    }
    $("#perimetar").mouseover(function(){
        $("#perimetar").html("");
        area = 0;
        area = firstInput.val() * secondInput.val();
        $("#perimetar").after(`<p id="area">${area}</p>`);
        $("#area").css("color", "red");
        $("#area").css("font-size", "50px");
        })
})

