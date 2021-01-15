let firstheader = document.getElementById("myTitle");
console.log(`Our first header text is: ${firstheader.innerText}`);
firstheader.innerText += "!!!!!";
console.log(`Our first header after the change is: ${firstheader.innerText}`);

let firstparagraph = document.getElementsByTagName("p");
console.log(`Our first paragraph text is: ${firstparagraph[0].innerText}`);
firstparagraph[0].innerText += " I solved it very quickly.";
console.log(`Our first paragraph after the change is: ${firstparagraph[0].innerText}`);

let secondparagraph = document.getElementsByTagName("p");
console.log(`Our second paragraph text is: ${secondparagraph[1].innerText}`);
secondparagraph[1].innerText += " It's very easy!!!";
console.log(`Our second paragraph after the change is: ${secondparagraph[1].innerText}`);

let secondheader = document.getElementsByTagName("h1")[1];
console.log(`Our second header text is: ${secondheader.innerText}`);
secondheader.innerText += ",to be exactly the homework.";
console.log(`Our second header text after the change is: ${secondheader.innerText}`);

let thirdheader = document.getElementsByTagName("h3")[0];
console.log(`Our third header text is: ${thirdheader.innerText}`);
thirdheader.innerText += " To be complete!";
console.log(`Our third header text is: ${thirdheader.innerText}`);
