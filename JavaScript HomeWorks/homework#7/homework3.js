var array = [];

function Students(fName,lName,age){
    this.firstName = fName;
    this.lastname = lName;
    this.years = age;
}

function addStudent(){
    let selectedfName = document.getElementById("firstname").value;
    let selectedlName = document.getElementById("lastname").value;
    let selectedAge = document.getElementById("years").value;
    let student = new Students(selectedfName, selectedlName, selectedAge);
    console.log(student);
    array.push(student);
    let ulElement = document.createElement("ul");
    let item = document.createElement("li");
    item.innerText = `${selectedfName} ${selectedlName} ${selectedAge}`;
    ulElement.appendChild(item);
    myDiv = document.getElementById("secondDiv");
    myDiv.appendChild(ulElement);
}

document.getElementById("myBut").addEventListener("click", addStudent);
