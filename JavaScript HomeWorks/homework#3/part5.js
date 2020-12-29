var balance = 3000;
var pin = prompt("Enter your pin"); 

function atm() {

    var choice = parseInt(prompt('Select a choice 1.Balance 2.Deposit 3.Withdrawal 4.Exit')); 
    /* birame od opciite na bankomatot sto ni e potrebno */

    if (choice === 1) { // 1 = get balance
        get_balance();
    } 
    
    else if (choice === 2) { // 2 = make deposit
        make_deposit();
    } 
    
    else if (choice === 3) { // 3 - make withdrawal
        make_withdrawal();
    } 
    
    else if (choice === 4) { // 4 - exit
        exit();
    } 
    
    else { // error
        error();
    }
}
	function get_balance() {

		alert('Your current balance is: '+balance); // momentalna sostojba
		atm();
	}

	function make_deposit() {
        var deposit = parseFloat(prompt('How much would you like to deposit?'));
        
		if (isNaN(deposit) || deposit === '') { // ako ne vneseme broj ili ostavime prazno pole se primenuva alertot

			alert('Error: please enter a number!');
			make_deposit(); // ja povikuvame povtorno se dodeka ne vneseme broj
        }

        else {

			balance += deposit;
			get_balance(); // se povikuva get balance od gore
		}
	}

	function make_withdrawal() {

		var withdrawal = parseFloat(prompt('How much would you like to withdrawal?')); 
		if (isNaN(withdrawal) || withdrawal === '') { // ako ne vneseme broj ili ostavime prazno pole se primenuva alertot

			alert('Error: please enter a number!');
			make_withdrawal(); // ja povikuvame povtorno se dodeka ne vneseme broj
        } 
        
        else {

			balance -= withdrawal;
			get_balance(); // se povikuva get balance od gore
		}
	}

	function error() {

		alert('Error: accepted numbers are 0 through 4.');
		atm();
	}

	function exit() {

		var leave = confirm('You have selected exit.'); // potvrda deka sme izbrale exit
		if (leave) {

			window.close(); // googlav i vidov deka ima vakva gotova funkcija za da iskoci funkcijata od samiot browser
        } 
        
        else {

			atm();
		}
	}

	atm();