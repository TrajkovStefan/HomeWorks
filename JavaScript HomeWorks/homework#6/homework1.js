let firstName = document.getElementsByTagName("input")[0];
let lastName = document.getElementsByTagName("input")[1];
let myButton = document.getElementsByTagName("input")[2];
let mySecondDiv = document.getElementById("content");

function greeting(){
    mySecondDiv.innerText = `Hello ${firstName.value} ${lastName.value}`;
}

myButton.addEventListener("click", function(event){
    greeting(event.target.value);
});

mySecondDiv.addEventListener("mouseover", function(){
    mySecondDiv.innerHTML = "";
});