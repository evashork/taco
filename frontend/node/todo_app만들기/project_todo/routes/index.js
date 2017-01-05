var express = require('express');
var router = express.Router();
var fs = require('fs');

/* GET home page. */
router.get('/', function(req, res, next) {
  fs.readFile('../database/todo.json','utf8', function(err,data){
  	if(err) throw err;
  	console.log(data);
  	if(data==(''||null)){
  		res.render('index',{todo:data});
  	}else{
  		res.render('index',{todo:JSON.parse(data)});
  	}
  });
});

router.post('/task-register', function(req,res){
	var task = [];
	var date = req.body.date;
	var newTask = req.body.task;

	var genId = new Date().getTime();

	var obj = {"id":genId,"date":date,"task":newTask,"done":false};

	fs.readFile('../database/todo.json','utf8', function(err,data){
		if (err) throw err;

		if (data != '') {
			task = JSON.parse(data);
		}
		console.log(task);
		task.todo.push(obj);

		fs.writeFile('../database/todo.json', JSON.stringify(task), function(err){
			if (err) throw err;
			console.log('saved!!');
			res.redirect('/');
		});
	});
});

module.exports = router;
