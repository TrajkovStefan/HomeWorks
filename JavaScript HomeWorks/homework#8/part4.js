$(document).ready(function(){

    function calcAverage(){
        let firstInput = $("input:first").val();
        let secondInput = $("input:nth-child(2)").val();
        let thirdInput = $("input:last").val();
        let average = 0;
        average += (Number(firstInput) + Number(secondInput) + Number(thirdInput)) / 3;
        if(average>=10){
            $("button").after(`<h1></h1>`);
            $("h1:first").text(`${average}`).css("color", "green");
        }
        else{
            $("button").after(`<h1></h1>`);
            $("h1:first").text(`${average}`).css("color", "red");
        }
    }

    $("button").click(function(){
        calcAverage();
    })
    
});