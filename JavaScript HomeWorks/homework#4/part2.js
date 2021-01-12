function sum(input) {

    var total = 0;
    for (var i = 0; i < input.length; i++) {
        total += Number(input[i]);
    }
    return total;
}
console.log(sum([1, 2, 3, 5, 8]));
