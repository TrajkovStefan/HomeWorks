$(document).ready(function(){

    let allOptions = $("option");
    
    function catchColor(valueOfOption){
        $("#content").text(`${valueOfOption}`);
        $("#content").css(`color`, `${valueOfOption}`);
        $("#content").css("background-color", "black");
    }
    $("input").click(function(){
        allOptions.remove();
        $("input").val("Catch");
        firstSelect = $("#myColor");
        firstSelect.append(`<option id="otherOption">Yellow</option>`);
        let otherOption = $("#otherOption");
        $("input").click(function(){    
            catchColor(otherOption.val());
        })
        

    });
});