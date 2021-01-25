let firstInput = $("input:first");
let secondInput = $("input:last");
let myButton = $("button");

myButton.click(function(){
    if(firstInput.val() && secondInput.val() === ""){
        alert("Enter the sides of rectangle");
    }
    else{
        let perimeter = 0;
        perimeter = 2*(firstInput.val() + secondInput.val()); 
        myButton.after(`<p>${perimeter}</p>`)
    }
    $("p").mouseover(function(){
        $("p").html("");
        area = 0;
        area = firstInput.val() * secondInput.val();
        $("p").after(`<p>${area}</p>`);
        $("p:last").css("color", "red");
        $("p:last").css("font-size", "50px");
        })
})
