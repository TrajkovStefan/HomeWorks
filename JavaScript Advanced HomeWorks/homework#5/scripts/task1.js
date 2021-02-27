// //with AsyncAwait
$(document).ready(function () {

    let array = [];
    let name;
    async function getDetails() {
        let details = await fetch("https://restcountries.eu/rest/v2/capital/tallinn");
        let data = await details.json();
        for (let code of data) {
            let result = code.currencies[0].code;
            let currency = await fetch(`https://restcountries.eu/rest/v2/currency/${result}`);
            let res = await currency.json();
            for (let names of res) {
                name = names.name;
                array.push(name);
                console.log(name);
                $("#header").append(`${name}<br>`);
            }
        }
        $("h4").append(`The number of countries is: ${array.length}`)
        console.log(`The number of countries is: ${array.length}`)
    }

    $("#myBtn").click(function () {
        $("#header").html("");
        getDetails();
    })
})

