let convertKg = 0;

function converterKg(){
let kg = parseInt(prompt("Enter your kilograms"));

if (isNaN(kg)){
    
    alert("Enter the number of kilograms");
    converterKg();
}
else{

    convertKg = kg/0.5;
    let firstParagraph = document.createElement("p");
    firstParagraph.innerText += "Converted kilograms is: " +convertKg;
    firstParagraph.setAttribute("class", "p");
    let firstDiv = document.getElementById("first");
    firstDiv.appendChild(firstParagraph);
}
}

function print(firstname){
    
    let header = document.createElement("h1");
    header.innerText = `Hello ${firstname}`;
    header.setAttribute("class", "h1");
    let firstDiv = document.getElementById("first");
    firstDiv.appendChild(header);   
}

let firstName = prompt("Enter your name");



print(firstName);
converterKg();



