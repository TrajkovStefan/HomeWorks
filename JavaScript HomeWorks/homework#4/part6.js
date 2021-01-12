let firstarray = ["Bob", "Jill", "Mark"];
console.log(`First array is: ${firstarray}`);
let secondarray = ["Greogry", "Wurtz", "Twain"];
console.log(`Second array is: ${secondarray}`);
let fullnames = [];

fullnames.unshift(`1.` + firstarray[0] + " " + secondarray[0]);
fullnames.push(` 2.` + firstarray[1] + " " + secondarray[1]);
fullnames.push(` 3.` + firstarray[2] + " " + secondarray[2]);
console.log(`The full array is: ${fullnames}`);