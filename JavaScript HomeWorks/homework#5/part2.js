let divList = document.getElementById("list");

let numbers = [2,4,3,2,8];

function Sum(numbersArray, element){
element.innerHTML = "";
element.innerHTML += "<h1>Your numbers is: </h1>";
element.innerHTML += "<ol>";

for(let i of numbersArray){
    element.innerHTML += `<li>${i}</li>`;
}
element.innerHTML += "</ol>";
}

Sum(numbers, divList);

function sum(numbers){
    let total = 0;
    for (let i = 0; i < numbers.length; i++){
        total += Number(numbers[i]);
    }
    return total;
}

document.write(`The sum of numbers is: `+sum(numbers));