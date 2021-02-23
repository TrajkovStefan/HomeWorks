$(document).ready(function () {

    let myHeader = $("#myHeader");

    function getInput(value) {
        return new Promise((resolve, reject) => {
            setTimeout(function () {
                if (typeof (value) === "string") {
                    resolve(value.toUpperCase());
                }
                else {
                    reject(value);
                }
            }, 4000)
        })
    }

    getInput("sedc")
        .then(success => {
            myHeader.text(success);
        })
        .catch(error => {
            myHeader.text(error);
        })

    getInput(22)
        .then(success => {
            myHeader.after(success);
        })
        .catch(error => {
            myHeader.after(error);
        })

    // SECOND WAY

    let myButton = $("#myButton");
    let myInput = $("#myInput");
    let mySecondHeader = $("#mySecondHeader");

    function getInputOther(value) {
        return new Promise((resolve, reject) => {
            setTimeout(function () {
                if (Number(value)) {
                    reject(value);
                }
                if (typeof (value) === "string") {
                    resolve(value.toUpperCase());
                }
            }, 4000)
        })
    }

    myButton.click(function () {
        getInputOther(myInput.val())
            .then(success => {
                mySecondHeader.text(success);
                myInput.val("");
            })
            .catch(error => {
                myInput.val("");
                mySecondHeader.after(error);
            })
    })
})


