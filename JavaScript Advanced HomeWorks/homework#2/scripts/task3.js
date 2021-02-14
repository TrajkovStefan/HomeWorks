let arrayOfFirstNames = ["Stefan", "Ana", "Kate", "Marija", "Petko"];
let arrayOfLastNames = ["Trajkov", "Anastasova", "Acoska", "Stojanovska", "Petkovski"];
let fullNames = [];

(function (fName, lName) {
    for (let i = 0; i < fName.length; i++) {
        fullNames.push(`${fName[i]} ${lName[i]}` + "");
    }
    return fullNames;
})(arrayOfFirstNames, arrayOfLastNames);

console.log(`${fullNames}`);


