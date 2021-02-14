$(document).ready(function () {

    let myButton = $("#firstTen");
    let nextButton = $("#next");
    let prevButton = $("#prev");
    let exitButton = $("#exit");
    let myTable = $("#myTable");
    myTable.css("border", "1px solid black");
    let nextUrl = "";
    let prevUrl = "";
    nextButton.hide();
    prevButton.hide();
    exitButton.hide();

    let firstTen = url => {
        $.ajax({
            url: url,
            success: (result) => {
                console.log(result);
                myTable.append("<thead>");
                let myTableHeader = $("thead");
                myTableHeader.append(`<tr><th>Planet Name</th><th>Rotation Period</th><th>Orbital Period</th><th>Diameter</th><th>Climate</th><th>Gravity</th><th>Terrain</th><th>Surface Water</th><th>Populaltion</th><th>Residents</th><th>Films</th><th>Created</th><th>Edited</th><th>Url</th></tr>`);
                let myTableBody = myTableHeader.after("<tbody>");
                myTableBody = $("tbody");
                for (i = 0; i <= 9; i++) {
                    myTableBody.append(`<tr><td>${result.results[i].name}</td><td>${result.results[i].rotation_period}</td><td>${result.results[i].orbital_period}</td><td>${result.results[i].diameter}</td><td>${result.results[i].climate}</td><td>${result.results[i].gravity}</td><td>${result.results[i].terrain}</td><td>${result.results[i].surface_water}</td><td>${result.results[i].population}</td><td>${result.results[i].residents.length}</td><td>${result.results[i].films}</td><td>${result.results[i].created}</td><td>${result.results[i].edited}</td><td>${result.results[i].url}</td></tr>`);
                }
                nextUrl = result.next;
                prevUrl = result.previous;
            },
            error: (err) => {
                console.log(err);
            }
        });
    }

    myButton.click(() => {
        myTable.html("");
        firstTen("https://swapi.dev/api/planets/?page=2");
        nextButton.show();
        prevButton.hide();
        exitButton.show();
    })

    nextButton.click(() => {
        myTable.html("");
        firstTen(nextUrl);
        nextButton.hide();
        prevButton.show();
    })

    prevButton.click(() => {
        myTable.html("");
        firstTen(prevUrl);
        prevButton.hide();
        nextButton.show();
    })

    exitButton.click(() => {
        window.close();
    })

});