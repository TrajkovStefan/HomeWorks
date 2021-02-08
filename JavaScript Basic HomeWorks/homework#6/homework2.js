let table = document.getElementById("sampleTable");
let myBut = document.querySelector("input");

myBut.addEventListener("click", function(){
    table.innerHTML += "<tr><td>Row3 cell1</td><td>Row3 cell2</td></tr>"

});

