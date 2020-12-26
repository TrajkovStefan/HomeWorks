//PART 1

var a= prompt("Enter the first number");
var b= prompt("Enter the second number");
var c= prompt("Enter the thirth number");
var d= prompt("Enter the fourth number");
var f= prompt("Enter the fifth number");

var a=parseInt(a);
var b=parseInt(b);
var c=parseInt(c);
var d=parseInt(d);
var f=parseInt(f);

if (a>b && a>c && a>d && a>f)
{
    alert(a);
}
else if (b>a && b>c && b>d && b>f)
{
    alert(b);
}
else if (c>a && c>b && c>d && c>f)
{
    alert(c);
}
else if (d>a && d>c && d>b && d>f)
{
    alert(d);
}
else
{
    alert(f);
}






