$(document).ready(function(){

    let cosmonaut = $("btnPeople");
    let myDiv = $(".row");

    function getPeople(){
        $.ajax({
            url:`https://swapi.dev/api/people/`,
            succes: function(result){
                myDiv.append(`<p>People: ${result.people}</p>`);
            },
            error: function(err){
                console.log(err);
            }
        })
    
    };
    cosmonaut.click(function(){
        getPeople();
    })
})


