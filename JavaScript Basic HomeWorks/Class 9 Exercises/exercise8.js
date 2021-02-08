function calcSalary(arrayOfPeople){
    let sumOfSalary = 0;
    for(let price of arrayOfPeople){
        sumOfSalary+= price.salary;
    }
    return sumOfSalary;
}

let array = [{fullName: "Stefan Trajkov", job:"photographer", salary:1000}, {fullName:"Dimitar Dimitrioski", job:"programmer", salary:1500}];
console.log(`The sum of salaries of all people is: ${calcSalary(array)}`);    