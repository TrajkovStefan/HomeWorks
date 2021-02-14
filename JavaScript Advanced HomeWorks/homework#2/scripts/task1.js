$(document).ready(function () {

    let myButton = $("button");
    let myTable = $("#myTable");
    myTable.css("border", "1px solid black");
    

    let siteUrl = url => {
        $.ajax({
            url: url,
            success: (result) => {
                console.log(result);
                myTable.append("<thead>");
                let myTableHeader = $("thead");
                myTableHeader.append(`<tr><th>Planet Name</th><th>Population</th><th>Climate</th><th>Gravity</th></tr>`);
                let myTableBody = myTableHeader.after("<tbody>");
                myTableBody = $("tbody");
                for (i = 0; i <= 9; i++) {
                    myTableBody.append(`<tr><td>${result.results[i].name}</td><td>${result.results[i].population}</td><td>${result.results[i].climate}</td><td>${result.results[i].gravity}</td></tr>`);
                }
                return;
            },
            error: (err) => {
                console.log(err);
            }
        });
    }

    myButton.click(() => {
        siteUrl("https://swapi.dev/api/planets/?page=1");
    })
})  