$(document).ready(function () {


    let myButton = $("#myButton");
    let firstHeader = $("#firstHeader").hide();
    let secondHeader = $("#secondHeader").hide();

    async function getDetails() {
        //get post with ID 1
        let responsePost = await fetch("https://jsonplaceholder.typicode.com/posts/1");
        let dataPost = await responsePost.json();
        getTableForPost(dataPost);
        //get user with UserId 1 
        let responseUser = await fetch(`https://jsonplaceholder.typicode.com/users/${dataPost.userId}`);
        let dataUser = await responseUser.json();
        getTableForUser(dataUser);
    }

    function getTableForPost(dataTable) {
        firstHeader.show();
        $("#resultsPost").html("");
        $("#resultsPost").html(`
        <table class="table-responsive">
        <thead>
        <tr>
        <th scope="col">User ID</th>
        <th scope="col">ID</th>
        <th scope="col">Title</th>
        <th scope="col">Body</th>
        </tr>
        </thead>
        <tbody>
        <tr>
        <td>${dataTable.userId}</td>
        <td>${dataTable.id}</td>
        <td>${dataTable.title}</td>
        <td>${dataTable.body}</td>
        </tr>
        </tbody>
        </table>
        `)
    }

    function getTableForUser(dataUsers) {
        secondHeader.show();
        $("#resultsUsers").html("");
        $("#resultsUsers").append(`
        <table class="table-responsive">
        <thead>
        <tr>
        <th scope="col">ID</th>
        <th scope="col">Name</th>
        <th scope="col">Username</th>
        <th scope="col">Email</th>
        <th scope="col">Street</th>
        <th scope="col">Suite</th>
        <th scope="col">City</th>
        <th scope="col">Zipcode</th>
        <th scope="col">lat</th>
        <th scope="col">lng</th>
        <th scope="col">phone</th>
        <th scope="col">website</th>
        <th scope="col">Company Name</th>
        <th scope="col">Company CatchPhrase</th>
        <th scope="col">Company Bs</th>
        </tr>
        </thead>
        <tbody>
        <tr>
        <td>${dataUsers.id}</td>
        <td>${dataUsers.name}</td>
        <td>${dataUsers.username}</td>
        <td>${dataUsers.email}</td>
        <td>${dataUsers.address.street}</td>
        <td>${dataUsers.address.suite}</td>
        <td>${dataUsers.address.city}</td>
        <td>${dataUsers.address.zipcode}</td>
        <td>${dataUsers.address.geo.lat}</td>
        <td>${dataUsers.address.geo.lng}</td>
        <td>${dataUsers.phone}</td>
        <td>${dataUsers.website}</td>
        <td>${dataUsers.company.name}</td>
        <td>${dataUsers.company.catchPhrase}</td>
        <td>${dataUsers.company.bs}</td>
        </tr>
        </tbody>
        </table>
        `)
    }

    myButton.click(() => {
        getDetails();
    })
})