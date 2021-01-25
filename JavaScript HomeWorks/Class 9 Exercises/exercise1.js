var arr = [NaN,3,2,0,undefined,"sedc",true,false];

var filtered = arr.filter(Boolean);
console.log(filtered);

// 2 WAY

function check(inputArray){
    let newArray = [];
    for(let i of inputArray){
        if(i){
            newArray.push(i);
        }
    }
    return newArray;
}

let nArr = check(arr);
console.log(nArr);
