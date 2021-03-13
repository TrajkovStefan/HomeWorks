const http = require("http");
const hostname = "127.0.0.1";
const port = 3000;

let array = [

    {
        firstName: "Stefan",
        lastName: "Trajkov",
        age: 23
    },

    {
        firstName: "Kate",
        lastName: "Johnson",
        age: 25
    }

]

const server = http.createServer((req, res) => {
    res.statusCode = 200;
    res.setHeader("Content-type", "application/json");
    res.write(JSON.stringify(array));
    res.end();
})
server.listen(port, hostname, () => {
    console.log(`Server listening on ${hostname} - ${port}`);
})