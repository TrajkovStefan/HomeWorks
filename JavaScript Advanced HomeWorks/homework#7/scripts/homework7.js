function Person(id, firstName, lastName, age) {
    this.id = id;
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.getFullName = function () {
        console.log(`${this.firstName} ${this.lastName}`);
    }
}

function Animal(name, age) {
    this.name = name;
    this.age = age;
    this.eat = function () {
        console.log(`The cat ${this.name} want to eat`);
    }
    this.sleep = function () {
        console.log(`The cat ${this.name} want to sleep`);
    }
}

function Cat(color, ownerId, name, age) {
    Object.setPrototypeOf(this, new Animal(name, age));
    this.color = color;
    this.ownerId = ownerId;
    this.meow = function () {
        console.log(`The cat ${this.name} says Meow!!!`);
    }
    this.printOwnerDetails = function (person) {
        if (this.ownerId == null || undefined) {
            console.log("The cat does not have owner!!!");
        }
        else {
            details = person.filter(p => p.id == this.ownerId)
            console.log(details[0]);
        }
    }
}

let colors = ["black", "white", "blue", "red", "gray"];

let persons = [new Person(1, "Stefan", "Trajkov", 23), new Person(3, "John", "Robertson", 20), new Person(2, "Kate", "Marison", 28), new Person(5, "Bob", "Bobsky", 25), new Person(6, "Ognen", "Ognenovski", 29)];

let cats = [new Cat(colors[0], 3, "Kitty", 5), new Cat(colors[2], 6, "Bella", 3)];

// ova mi e ostaveno zakomentirano, bidejki ne mi sakase vaka da se dodade funkcija.. kade mi e greskata ako moze da mi kazete

// Cat.prototype.printOwnerDetails =  function (person) {
    //     if (this.ownerId == null || undefined) {
    //         console.log("The cat does not have owner!!!");           
    //     }
    //     else {
    //         details = person.filter(p => p.id == this.ownerId)
    //         console.log(details[0]);
    //     }
    // }
// }

function PersianCat(eyeColor, color, ownerId, name, age) {
    Object.setPrototypeOf(this, new Cat(color, ownerId, name, age));
    this.eyeColor = eyeColor;
    this.furDescription = function () {
        console.log(`The cat ${this.name} has full fur!`);
    }
}

function RagDollCat(weight, isFriendly, color, ownerId, name, age) {
    Object.setPrototypeOf(this, new Cat(color, ownerId, name, age));
    this.weight = weight;
    this.isFriendly = isFriendly;
    this.printPersonality = function (type) {
        if (type == true) {
            console.log(`The cat ${this.name} is friendly!!`);
            isFriendly = true;
        }
        else {
            console.log(`The cat ${this.name} is not friendly!!`);
            isFriendly = false;
        }
    }
}

let persianCat = new PersianCat("green", colors[1], 2, "Luli", 2);
let ragDollCat = new RagDollCat("black", Boolean, colors[3], 1, "Bleki", 5);

persons[0].getFullName();
cats[0].eat();
cats[1].sleep();
cats[0].printOwnerDetails(persons);
cats[1].printOwnerDetails(persons);
persianCat.furDescription();
persianCat.printOwnerDetails(persons);
ragDollCat.printOwnerDetails(persons);
ragDollCat.printPersonality(true);
ragDollCat.printPersonality(false);
