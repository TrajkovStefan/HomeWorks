$(document).ready(function(){
    let acc;
    let pin = $("#pin");
    let agree = $("#button1");
    let h4 = $("h4");

    let value = $("#value");
    let deposit = $("#button2");
    let withdrawal = $("#button3");
    let balance = $("#button4");
    let exit = $("#button5");

    function Atm(pin){
        this.pin = pin;
        this.balance = 3000;

        this.deposit = function(amount){
            this.balance += parseInt(amount);
        }

        this.withdrawal = function(amount){
            this.balance -= parseInt(amount);
        }
    }

    agree.click(function(){
        if(!pin.val()){
            h4.text("No pin entered");
            return;
        }

        h4.text("");

        acc = new Atm(pin.val());
    })

    deposit.click(function(){
        if(!value.val()){
            h4.text("No amount entered");
            return;
        }

        h4.text("");
        
        acc.deposit(value.val());
        h4.text(`Account balance is: ${acc.balance}`);
    })

    withdrawal.click(function(){
        if(!value.val()){
            h4.text("No amount entered");
        }
        h4.text("");

        acc.withdrawal(value.val());
        h4.text(`Acount balance is: ${acc.balance}`);
    })

    balance.click(function(){
        h4.text(`Account balance is: ${acc.balance}`);
    })

    exit.click(function(){
        window.close();
    })
})