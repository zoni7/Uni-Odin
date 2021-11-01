const net = require('net');
const fs = require('fs')


const server = net.createServer(
    function(c) { //connection listener
        console.log('server: client connected');
        c.on('end',
            function() {
                console.log('server: client disconnected');
        });
        c.on('data',
            function(data) {
                c.write('localhost :' + getLoad()); // send resp
                
                c.end(); // close socket
        });
    });

    function getLoad(){
        data=fs.readFileSync("/proc/loadavg"); //requiere fs
        var tokens = data.toString().split(' ');
        var min1 = parseFloat(tokens[0])+0.01;
        var min5 = parseFloat(tokens[1])+0.01;
        var min15 = parseFloat(tokens[2])+0.01;
        return min1*10+min5*2+min15;
        };
        
    server.listen(8000,
        function() { //listening listener
            console.log('server bound');
        });
