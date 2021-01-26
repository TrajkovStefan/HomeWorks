$(document).ready(function(){

    myInput = $("#circleRadius");
    createCircle = $("#myCircle");
    getArea = $("#getArea");
    getPerimeter = $("#getPerimeter");
    
    
    let circle;
    
    createCircle.click(function(){
        circle = {
            radius:myInput.val(),
            getArea: function(){
                const pi = 3.14;
                return this.radius*this.radius*pi;
            },
            getPerimeter: function(){
                const pi = 3.14;
                return 2*this.radius*pi;
            }
        }
    })
    
    getArea.click(function(){
        getPerimeter.after(`<p>${circle.getArea()}<p>`);
    })
    getPerimeter.click(function(){
        getPerimeter.after(`<p>${circle.getPerimeter()}<p>`);
    })
    })