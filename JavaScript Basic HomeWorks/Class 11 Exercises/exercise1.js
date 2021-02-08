$(document).ready(function(){
    function arrayNumbers(arrayOfnumbers){
        let newArray = [];
        
        for(let i of arrayOfnumbers){
            if(isNaN(i))
            return false;
        }
        for (let i=1;i<=arrayOfnumbers.length; i++){
            newArray.push(arrayOfnumbers[i-1]);
            if(arrayOfnumbers[i-1]%2==0 && arrayOfnumbers[i]%2==0){
                newArray.push("-");
            }
        }
        return newArray;
    }

    let arrayOfnumbers = [0,2,5,4,6,8,12,3,1];

    let button = $("button");
    let arrayDashes = arrayNumbers(arrayOfnumbers);
    button.click(function(){
        console.log(arrayDashes);
    })

})