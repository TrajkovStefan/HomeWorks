$(document).ready(function(){

    let allOptions = $("option");
    
    $("input").click(function(){
        allOptions.hide();
        $("input").val("Catch");
        firstSelect = $("#myColor");
        addNewOption = firstSelect.html(`<select><option value="Yellow">Yellow</option></select>`);
        $("#content").after(`<p>${addNewOption.val()}</p>`);
        $("p").css("color", "yellow");
        $("p").css("background-color", "black");

    });
});