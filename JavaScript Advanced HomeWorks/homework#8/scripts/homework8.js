class Person {
    constructor(firstName, lastName, age, address) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.address = address;
    }
    fullName() {
        console.log(`${this.firstName} ${this.lastName}`);
    }
    //getter and setter for firstName
    set firstName(fName) {
        if (!fName) {
            throw new Error("Enter the first name");
        }
        else {
            console.log("Setting the fName");
            this._firstName = fName;
        }
    }
    get firstName() {
        console.log("Getting the value for firstName");
        return this._firstName;
    }
    //getter and setter for lastName
    set lastName(lName) {
        if (!lName) {
            throw new Error("Enter the last name");
        }
        else {
            console.log("Setting the lName");
            this._lastName = lName;
        }
    }
    get lastName() {
        console.log("Getting the value for lastName");
        return this._lastName;
    }
    //getter and setter for age
    set age(agePerson) {
        if (!agePerson) {
            throw new Error("Enter the age");
        }
        else {
            console.log("Setting the age");
            this._age = agePerson;
        }
    }
    get age() {
        console.log("Getting the value for age");
        return this._age;
    }
    //getter and setter for address
    set address(addressPerson) {
        if (!addressPerson) {
            throw new Error("Enter the address");
        }
        else {
            console.log("Setting the address");
            this._address = addressPerson;
        }
    }
    get address() {
        console.log("Getting the value for address");
        return this._address;
    }
}

class Student extends Person{
    constructor(firstName, lastName, age, address, arrayOfSubjects){
        super(firstName, lastName, age, address);
        this.arrayOfSubjects = arrayOfSubjects;
        this.academy = "SEDC";
    }
    static check(student, subject){
        if(student instanceof Student){
            if(student.arrayOfSubjects.includes(subject)){
                console.log(`The student studying ${subject}`);
                return;
            }
            else{
                console.log(`The student does not study ${subject}`);
            }
        }
    }
}

let students = [new Student("Stefan", "Trajkov", 23, "Skopje", ["Java", "Python"]), new Student("Robi", "Robinson", 25, "USA", ["HTML", "Python"]), new Student("Kate", "Richardson", 22, "England", [".Net", "TypeScript"])];

Student.check(students[0], "Python");
Student.check(students[1], ".Net");
students[1].fullName();

