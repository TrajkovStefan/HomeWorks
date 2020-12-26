// PART 3

var year = prompt("Enter a year");
var year = parseInt(year);

function chineseZodiac(year) {
    switch ((year - 4) % 12) {
        case 0:
            return 'Rat';

        case 1:
            return 'Ox';

        case 2:
            return 'Tiger';

        case 3:
            return 'Rabbit';

        case 4:
            return 'Dragon';

        case 5:
            return 'Snake';

        case 6:
            return 'Horse';

        case 7:
            return 'Goat';

        case 8:
            return 'Monkey';

        case 9:
            return 'Rooster';

        case 10:
            return 'Dog';

        case 11:
            return 'Pig';

    }
}

animal = chineseZodiac(year);
alert(year + ' is a ' + animal);


/* Namerno ja reshiv so switch i function, bidejki imam nekoe malo poznavanje od fakultet sto imame uceno
 i dobro mi dojde da se potsetam bidejki imam podzaboraveno i so if/else bi bila dosta poslozena */

/* vo tagot function ja zadavme funkcijata, vo switch ravenkata(kalkulacijata) sto treba da se presmetuva,
a vo case gi imame site mozni vrednosti od 0 do 11 i so return ja vrakjame nivnata vrednost na nekoj nacin */

