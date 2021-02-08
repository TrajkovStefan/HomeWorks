let myButton = document.getElementById("but");
let myDiv = document.getElementById("myDiv");
let array = [];

function save(){
    
    let inputs = document.getElementsByName("txt");
    for(i=0; i<inputs.length; i++){
        array.push(inputs[i].value);
    }
    return array;
}

myButton.addEventListener("click", function(event){
    save(event.target.value);
    myDiv.innerHTML += `<p>${array}</p>`;
});