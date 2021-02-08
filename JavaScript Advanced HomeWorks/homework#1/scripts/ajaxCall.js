$(document).ready(function () {
    $("button").click(function () {
        $.ajax({
            headers: {
                "Access-Control-Allow-Origin": "*"
            },
            url: `https://pokeapi.co/api/v2/pokemon`,
            success: function (results) {
                console.log(results);
                for (i = 9; i >= 0; i--) {
                    $("ul").after(`<li>${results.results[i].url}</li><hr>`)
                    $("ul").after(`<li>${results.results[i].name}</li>`);
                }
            },
            error: function (err) {
                console.log(err);
            }

        })
    })
})