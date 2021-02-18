function Product(name, category, hasDiscount, price) {
    this.name = name;
    this.category = category;
    this.hasDiscount = hasDiscount;
    this.price = price;
}

let arrayOfProducts = [new Product("camera", "mirrorless cameras", false, 1000), new Product("cheese", "food", false, 30), new Product("samsung S10", "techonolgy", true, 100), new Product("steak", "food", false, 24), new Product("sneakers", "footwear", true, 70), new Product("hamburger", "food", false, 60), new Product("milk", "food", true, 17), new Product("chocolate", "food", true, 15), new Product("apple laptop", "techonolgy", false, 18), new Product("glasses", "optics", true, 12), new Product("jeans", "clothes", false, 120), new Product("sweatshirt", "clothes", false, 19), new Product("eggs", "food", false, 14), new Product("knife", "tools", false, 28), new Product("headphones", "techonolgy", false, 11)];

console.log("===PRODCUTS OVER 20===");
function printProductsWithPriceAbove20(product) {
    console.log(`${product.name} has price ${product.price}`);
}


//price above 20
let productsAbove20 = arrayOfProducts.filter(product => product.price > 20);
productsAbove20.forEach(printProductsWithPriceAbove20);


//category food with discount
let productsOfFoodWithDiscount = arrayOfProducts.filter(products => products.category === "food" && products.hasDiscount === true)
    .map(product => product.name);
console.log("===PRODUCTS THAT HAVE A FOOD CATEGORY AND ARE ON DISCOUNT===");
console.log(productsOfFoodWithDiscount);


//average price of all products that are on discount
function calcAverageOfProducts(sum, products) {
    return sum += products;
}

let AllProductsWithDiscount = arrayOfProducts.filter(products => products.hasDiscount === true)
let priceOfProductsWithDiscount = AllProductsWithDiscount.map(products => products.price).reduce(calcAverageOfProducts, 0);
console.log(`The sum of all products that have a discount is ${priceOfProductsWithDiscount}`);
let average = priceOfProductsWithDiscount / AllProductsWithDiscount.length;
console.log(`The average price of all products that are on discount is ${average}`);


//products with name string with a vowel, that are not on discount
let AllProductsWithoutDiscount = arrayOfProducts.filter(products => products.hasDiscount === false).map(products => `${products.name} price: ${products.price}`)
console.log("===PRODUCTS WITHOUT DISCOUNT===");
console.log(AllProductsWithoutDiscount);
console.log("===PRODUCTS WITHOUT DISCOUNT AND START WITH A VOWEL===");
console.log(AllProductsWithoutDiscount.filter(products => /^[aeiou]/i.test(products)));


//sort products by price ascending
function copyArray(array) {
    let copyarray = [];
    array.forEach(a => copyarray.push(a));
    return copyarray;
}

console.log("===WITH COPY ARRAY===");
let productsCopy = copyArray(arrayOfProducts);
productsCopy.sort((p1, p2) => p2.price - p1.price);
productsCopy.forEach(products => console.log(products.price));





