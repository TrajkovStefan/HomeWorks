$(document).ready(function () {

    let body = $("body");
    let cosmonaut = $("#btnPeople");
    let ships = $("#btnShips");
    let nexBut = $("#btnNext");
    let prevBut = $("#btnPrev");
    let j = 1;
    let s = 1;

    let myTable = body.append(`<table>`);
    let myRealTable = $("table");

    function getPeople() {
        flag = true;
        $.ajax({
            url: `https://swapi.dev/api/people/?page=${j}`,
            success: function (result) {
                myRealTable.text("");
                myRealTable.append(`<thead>`);
                let myTableHead = $("thead");
                myTableHead.append("<tr><th>Name</th><th>Height</th><th>Mass</th><th>Gender</th><th>Birth year</th><th>Films</th></tr></th>");
                let tableBody = myTableHead.after("<tbody>");
                let myRealTableBody = $("tbody");
                for (let i = 0; i < result.results.length; i++) {
                    myRealTableBody.append(`<tr><td>${result.results[i].name}</td><td>${result.results[i].height}</td><td>${result.results[i].mass}</td><td>${result.results[i].gender}</td><td>${result.results[i].birth_year}</td><td>${result.results[i].films.length}</td></tr>`)
                }
            },
            error: function (err) {
                console.log(err);
            },
        });
    }

    function getShips() {
        flag = false;
        $.ajax({
            url: `https://swapi.dev/api/starships/?page=${s}`,
            success: function (result) {
                myRealTable.text("");
                myRealTable.append(`<thead>`);
                let myTableHead = $("thead");
                myTableHead.append("<tr><th>Name</th><th>Model</th><th>Manufacturer</th><th>Cost</th><th>People Capacity</th><th>Class</th></tr>");
                let tableBody = myTableHead.after("<tbody>");
                let myRealTableBody = $("tbody");
                for (let i = 0; i < result.results.length; i++) {
                    myRealTableBody.append(`<tr><td>${result.results[i].name}</td><td>${result.results[i].model}</td><td>${result.results[i].manufacturer}</td><td>${result.results[i].cost_in_credits}</td><td>${result.results[i].passengers}</td><td>${result.results[i].starship_class}</td></tr>`)
                }
            },
            error: function (err) {
                console.log(err);
            }
        })
    }

    cosmonaut.click(function () {
        getPeople();
    });

    ships.click(function () {
        getShips();
    })

    nexBut.click(function () {
        if (flag === true) {
            j++;
            getPeople();
            myRealTable.text("");
        }
        else {
            s++;
            getShips();
            myRealTable.text("");
        }
    })

    prevBut.click(function () {
        if (flag === true) {
            j--;
            getPeople();
            myRealTable.text("");
        }
        else {
            s--;
            getShips();
            myRealTable.text("");
        }

    })

})


