function printFactorial(num){
    if(isNaN(num)){
        alert(`Enter the number`);
        return;
    }
    if(num===0){
        return 1;
    }
    console.log(`${num}`);
    return num*printFactorial(num-1);
}

console.log(printFactorial(prompt(`Enter the number`)));