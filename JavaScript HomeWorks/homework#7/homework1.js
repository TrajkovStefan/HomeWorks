let animal = {
    name: "Dog",
    kind: "Beagle",
    printMessage: function(speak){
        
        alert(`${this.name} ${this.kind} says: ${speak}!!!`);
    }

}

dogSpeak = prompt(`What does the dog say?`);

animal.printMessage(dogSpeak);