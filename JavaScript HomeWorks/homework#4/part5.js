let Numbers = [1, 5, 12, 4, 2, 18, -1, 6, "sedc", true];

let max = Numbers[0];

for (let i= 0; i < Numbers.length; i++) {
    if (Numbers[i] >= max){
        max = Numbers[i];
        
    }
}

console.log(max);

let min = Numbers[0];

for (let i= 0; i < Numbers.length; i++) {
    if (Numbers[i] < min){
        min = Numbers[i];
        
    }
}

console.log(min);

sum = max + min;

console.log("The sum of max and min is: " +sum);

