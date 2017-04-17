const http = require('http');
 
const hostname = '127.0.0.1';	
const port = 1337;

/* 서버 생성 */ 
http.createServer((req, res) => {
  res.writeHead(200, { 'Content-Type': 'text/plain' });
  res.end('Hello World\n');
}).listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);	
});

/* 상단의 코드와 하단의 코드는 동일하다 */
var server = http.createServer(function(req,res){
	  res.writeHead(200, { 'Content-Type': 'text/plain' });
             res.end('Hello World\n');
});

server.listen(port, hostname, function() {
	console.log(`Server running at http://${hostname}:${port}/`);
});
