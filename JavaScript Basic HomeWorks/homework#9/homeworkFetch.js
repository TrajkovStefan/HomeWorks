let myButton = document.getElementById("myBut");
let myDiv = document.getElementById("myDiv");
let number = prompt(`Enter the number of todo`);

myButton.addEventListener("click", function(){
    fetch(`https://jsonplaceholder.typicode.com/todos/${number}`)
    .then(response =>{
        response.json()
        .then(data=>{
            let paragraph = document.createElement("p");
            paragraph.innerText = `ID: ${data.id}, TITLE: ${data.title}`;
            myDiv.appendChild(paragraph);
            if(data.completed === true){
                let otherParagraph = document.createElement("p");
                otherParagraph.innerText = "Completed";
                otherParagraph.style.color = "green";
                myDiv.appendChild(otherParagraph);
            }
            else{
                let otherParagraph1 = document.createElement("p");
                otherParagraph1.innerText = "Not Completed";
                otherParagraph1.style.color = "red";
                myDiv.appendChild(otherParagraph1);
            }
        });
    })
    .catch(err=>{
        console.log(err);
    })
})
