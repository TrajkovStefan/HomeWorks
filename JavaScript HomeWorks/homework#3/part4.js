function numbers(){

    let a = parseInt(prompt("Numbers of girls"));
    let b = parseInt(prompt("Numbers of boys"));

    if(a<10 && b<10){
    console.log(`0${a} girls`);
    console.log(`0${b} boys`);
    }
    else if(a>10 && b<10){
        console.log(`${a} girls`);
        console.log(`0${b} boys`);
    }
    else if(a<10 && b>10){
        console.log(`0${a} girls`);
        console.log(`${b} boys`);
    }
    else {
    console.log(`${a} girls`);
    console.log(`${b} boys`);
    }
}

numbers();