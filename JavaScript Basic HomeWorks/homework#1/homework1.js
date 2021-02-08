// EXERCISE 1 

console.log("EXERCISE 1");

var variable = true;
console.log(variable);
console.log(typeof(variable));

var variable = 6;
console.log(variable);
console.log(typeof(variable));

var variable = "6";
console.log(variable);
console.log(typeof(variable));


// EXERCISE 2

console.log("EXERCISE 2");

var PhonePrice = 119.95;
var totalprice = null;
var totalpriceuser = null;

totalpriceuser = PhonePrice/100*5;
totalpriceuser+= PhonePrice;

totalprice = totalpriceuser*30;

console.log("Total price for one phone with tax rate is: ");
console.log(totalpriceuser);
console.log("Total price for 30 phones with tax rate is: ");
console.log(totalprice);

//BONUS

console.log("BONUS");

var Phoneprice = prompt ("Enter the price of the phone");
var totalPrice = null;
var totalPriceuser = null;
var tax = prompt ("Enter the tax rate");

totalPriceuser = Phoneprice/100*tax;
totalPriceuser+= Phoneprice;

totalPrice = totalPriceuser*30;

console.log("Total price for one phone with tax rate is: ");
console.log(totalPriceuser);
console.log("Total price for 30 phones with tax rate is: ");
console.log(totalPrice);


// EXERCISE 3

console.log("EXERCISE 3");

var π = 3.14;
var r = prompt("Еnter the diameter of the circle");
var area = null;

area = π * r;

console.log("The area of ​​the circle is: ");
console.log(area);