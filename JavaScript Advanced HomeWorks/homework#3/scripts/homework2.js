$(document).ready(function(){
    let myfirstBtn = $("#myButton");
    let mySecondBtn = $("#mySecondBtn");
    let myThirdBtn = $("#myThirdBtn");
    let myFourthBtn = $("#myFourthBtn");
    let myfifthBtn = $("#myFifthBtn");
    let space = "";

    myfirstBtn.click(function(){
        $.ajax({
            url: ` https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json`,
            success: function(response){
                let parsedObject = JSON.parse(response);
                let printAllStudentsWithAverageAbove3 = parsedObject.filter(students => students.averageGrade > 3).map(students => (`${space} ${students.firstName} ${students.averageGrade}`));
                $("#results").html(`
                <table class="table">
                <thead>
                <tr>
                <th scope="col">All Students With Average Above 3</th>
                </tr>
                </thead>
                <tbody>
                <tr>
                <td>${printAllStudentsWithAverageAbove3}</td>
                </tr>
                </tbody>
                </table>
                `)
            },
            error: function (err){
                console.log(err);
            }
        })
    })

    mySecondBtn.click(function(){
        $.ajax({
            url: ` https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json`,
            success: function(response){
                let parsedObject = JSON.parse(response);
                let printAllFemaleStudentsWithGrade5 = parsedObject.filter(students => students.averageGrade == 5 && students.gender == "Female").map(students => (`${space} ${students.firstName} ${space} ${students.averageGrade}`));
                $("#results").html("");
                $("#results").html(`
                <table class="table">
                <thead>
                <tr>
                <th scope="col">All Female Students With Grade 5</th>
                </tr>
                </thead>
                <tbody>
                <tr>
                <td>${printAllFemaleStudentsWithGrade5}</td>
                </tr>
                </tbody>
                </table>
                `)
            },
            error: function (err){
                console.log(err);
            }
        })
    })

    myThirdBtn.click(function(){
        $.ajax({
            url: ` https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json`,
            success: function(response){
                let parsedObject = JSON.parse(response);
                let printAllMaleStudentsWhoLivesInSkopje = parsedObject.filter(students => students.age > 18 && students.city == "Skopje" && students.gender == "Male").map(students => (`${space} ${students.firstName} ${students.lastName} ${students.city} Age: ${students.age}`));
                $("#results").html("");
                $("#results").html(`
                <table class="table">
                <thead>
                <tr>
                <th scope="col">All Male Students Who Lives In Skopje</th>
                </tr>
                </thead>
                <tbody>
                <tr>
                <td>${printAllMaleStudentsWhoLivesInSkopje}</td>
                </tr>
                </tbody>
                </table>
                `)
            },
            error: function (err){
                console.log(err);
            }
        })
    })

    myFourthBtn.click(function(){
        $.ajax({
            url: ` https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json`,
            success: function(response){
                let parsedObject = JSON.parse(response);
                let printAllFemaleStudentsOverTheAgeOf24 = parsedObject.filter(students => students.age > 24 && students.gender == "Female").map(students => (`${space} ${students.firstName} ${students.lastName} Age: ${students.age} Average Grade: ${students.averageGrade}`));
                $("#results").html("");
                $("#results").html(`
                <table class="table">
                <thead>
                <tr>
                <th scope="col">All Female Students Over The Age 24</th>
                </tr>
                </thead>
                <tbody>
                <tr>
                <td>${printAllFemaleStudentsOverTheAgeOf24}</td>
                </tr>
                </tbody>
                </table>
                `)
            },
            error: function (err){
                console.log(err);
            }
        })
    })

    myfifthBtn.click(function(){
        $.ajax({
            url: ` https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json`,
            success: function(response){
                let parsedObject = JSON.parse(response);
                let printAllMaleStudentsWithNameStartingWithBAndAverageGradeOver2 = parsedObject.filter(students => students.averageGrade > 2 && students.gender == "Male").map(students => (`${students.firstName} ${students.averageGrade}`));
                $("#results").html("");
                $("#results").html(`
                <table class="table">
                <thead>
                <tr>
                <th scope="col">All Male Students With Name Starting With B And Average Grade Over 2</th>
                </tr>
                </thead>
                <tbody>
                <tr>
                <td>${printAllMaleStudentsWithNameStartingWithBAndAverageGradeOver2.filter(products => /^[B]/.test(products))}</td>
                </tr>
                </tbody>
                </table>
                `)
            },
            error: function (err){
                console.log(err);
            }
        })
    })

})