$(document).ready(function(){
    let myButton = $("#myBut");
    let myDiv = $("#myDiv");
    let number = prompt(`Enter the number of todo`);
    let myTable = $("#myTable");

    function getTodo(number){
        $.ajax({
            url: `https://jsonplaceholder.typicode.com/todos/${number}`,
            success: function(result){
                myTable.append(`<tr><th>ID</th><th>TITLE</th></tr><tr><td>${result.id}</td><td>${result.title}</td>`);
                myTable.css("border", "1px solid black");
                $("th").css("background-color", "#4CAF50");
                $("th").css("color", "white");
                $("td").css("background-color", "#ff6666");
                $("td").css("color", "white");
                if(result.completed === true){
                    myDiv.append(`<p>Completed</p>`);
                }
                else{
                    myDiv.append(`<p>Not Completed</p>`);
                }
            },
            error: function(err){
                console.log(err);
            }
        })
    };
    myButton.click(function(){
        getTodo(number);
    });
})