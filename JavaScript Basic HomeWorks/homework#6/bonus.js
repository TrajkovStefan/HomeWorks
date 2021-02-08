function createTable(){
    rows = prompt("Enter number of rows: ");
    cols = prompt("Enter number of columns: ");

    for(let r=0; r<parseInt(rows); r++){
        let x=document.getElementById("myTable").insertRow(r);
        
        for(let c=0; c<parseInt(cols); c++){
            let y= x.insertCell(c);
            y.innerHTML= "Row" +r+ "Column" +c;
        }
    }

}

myButton = document.getElementById("myBut");

myButton.addEventListener("click", createTable);