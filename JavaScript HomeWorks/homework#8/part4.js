$(document).ready(function(){

    function calcAverage(){
        let firstInput = $("input:first").val();
        let secondInput = $("input:nth-child(2)").val();
        let thirdInput = $("input:last").val();
        let average = 0;
        average += (Number(firstInput) + Number(secondInput) + Number(thirdInput)) / 3;
        if(average>=10){
            $("h1").text("");
            $("button").after(`<h1>${average}</h1>`);
            $("h1").css("color", "green");
        }
        else{
            $("h1").text("");
            $("button").after(`<h1>${average}</h1>`);
            $("h1").css("color", "red");
        }
    }

    $("button").click(function(){
        calcAverage();
    })
    
});