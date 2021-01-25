let array = [2,5,8,3,4,12,22,25];

function checkArray(arr){
    let evenArray = [];
    let oddArray = [];
    for(let i of arr ){
        if(isNaN(i)){
            console.log("Аll members should have numbers");
            return false;
        }
        if(i%2 == 0){
            evenArray.push(i);
        }
        else{
            oddArray.push(i);
        }
    }
    console.log(evenArray);
    console.log(oddArray);
}

checkArray(array);