const fs = require("fs");
let json = "students.json";

module.exports = {
    writeFile: function(text){
        fs.writeFileSync(json, text, function(err) {
            if(err){
                return console.log(err);
            }
            console.log("The file was saved!");
        })
    },
    readAndParseJsonFile: function(){
        let content = fs.readFileSync(jsonFile, {encoding: 'utf-8'});
        console.log(content);
        return JSON.parse(content);
    }
}