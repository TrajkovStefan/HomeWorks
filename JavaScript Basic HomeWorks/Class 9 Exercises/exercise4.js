array = ["sedc", "programming", "developer", "javascript"];

function arrayOfString(){
    for(let i of array){
        if(i.toString().length>10){
            return i;
        }
    }
}

arrayOfString(array);
console.log(arrayOfString(array));