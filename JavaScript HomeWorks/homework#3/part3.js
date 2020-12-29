alert('Calculation of canine and human age. Press OK to continue');

var year = parseInt(prompt("Enter the human year"));

function years(year){
    var humanYear = year * 7;
    return humanYear;

}

dogYears = years(year);
alert(' The dog\'s age in dog years is ' + dogYears + ' years ');
humanYears = dogYears / 7;
alert(' The age of the dog in human years is ' + humanYears + ' years ');

