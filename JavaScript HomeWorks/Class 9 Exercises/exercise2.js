let number = prompt("Enter the number");

function check1(){
    
    if(number>0){
        console.log("The number is positive");
    }
    else{
        console.log("The number is negative");
    }
}
function check2(number){
    var count = 0;
    if (number >= 1) ++count;
  
    while (number / 10 >= 1) {
      number /= 10;
      ++count;
    }
  
    return count;
  }

function check3(){
    if(number%2 == 0){
        console.log("Number is even");
    }   
    else{
        console.log("Number is odd");
    }
}

check1();
console.log(check2(number));
check3();