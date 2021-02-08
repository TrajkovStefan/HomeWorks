let myTable = document.querySelector("table");
myTableHeader = document.createElement("thead");
myTableBody = document.createElement("tbody");
document.querySelector("button").addEventListener("click", function(){
    fetch("https://jsonplaceholder.typicode.com/users/1")
    .then(function(response){
       console.log(response);
       response.json().then(
           function(data){
               console.log(data);
            myTableHeader.innerHTML += "<tr><th>Id</th><th>Name</th><th>Username</th><th>Email</th><th>Adress</th><th>Geo</th><th>Phone</th><th>Website</th><th>Company</th></tr>";
            myTable.appendChild(myTableHeader);
            myTableBody.innerHTML += `<tr><td>${data.id}</td><td>${data.name}</td><td>${data.username}</td><td>${data.email}</td><td>${data.address.street}<br>${data.address.suite}<br>${data.address.city}<br>${data.address.zipcode}</td><td>${data.address.geo.lat}<br>${data.address.geo.lng}</td><td>${data.phone}</td><td>${data.website}</td><td>${data.company.name}<br>${data.company.catchPhrase}<br>${data.company.bs}</td></tr>`;
            myTable.appendChild(myTableBody);
           }
       )
    })
    .catch(function(error){
        console.log(error)
    });
});