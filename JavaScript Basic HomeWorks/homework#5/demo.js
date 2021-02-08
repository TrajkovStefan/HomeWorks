let contentDiv = document.getElementById("first");

let nameOfRecepie = prompt("Enter name of recepie: ");
console.log(`${nameOfRecepie}`);
let manyIngredients = prompt(`How many ingredients do you need for ${nameOfRecepie}?`);
console.log(`${manyIngredients}`);

let array = [];
for(let i = 0; i<manyIngredients; i++){
    array.push(prompt(`Enter the ingrediets `+ (i+1)));
}
    

function printRecepie(array,element){
    element.innerHTML += `<h1>${nameOfRecepie}</h1>`;
    let ulElement = document.createElement("ul");

    for(let i in array){
        let item = document.createElement("li");
        item.innerText = `${array[i]}`
        ulElement.appendChild(item);
    }
    element.appendChild(ulElement);
}

printRecepie(array,contentDiv);
