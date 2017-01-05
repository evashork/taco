var express = require('express');
var app = express();
var http = require('http').Server(app);
var io = require('socket.io')(http);

app.get("/",function(req,res){
	res.sendfile("client.html");
});

var count = 1;
io.on('connection',function(socket){
	console.log('user connected: ', socket.id);
	var name = "user" + count++;
	io.to(socket.id).emit('chage name',name);

	socket.on('disconnect',function(){
		console.log('user disconnect:', socket.id);
	});

	socket.on('send message', function(name,text){
		var msg = name + ' : ' + text;
		console.log(msg);
		io.emit('receive message', msg);
	});
});

http.listen('3000', function(){
	console.log("Server on!");
});

