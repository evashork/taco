var express = require('express');
var mongoose = require('mongoose');
var bodyParser = require('body-parser');
var app = express();


// DB 설정
mongoose.connect('');
var db = mongoose.connection;

db.once("open", function(){
	console.log("DB connected");
});

db.on("error",function(err){
	console.log("DB ERROR : ", err);
});

// express 설정
app.set("view engine", "ejs");
app.use(express.static(__dirname+"/public"));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended:true}));

// DB 스키마
var contactSchema = mongoose.Schema({
	name:{type:String, require:true, unique:true},
	email:{type:String},
	phone:{type:String}
});
var Contact = mongoose.model('Contact', contactSchema);

// Routes 경로 설정
// /home
app.get("/", function(req,res){
	res.redirect("/contacts");
});
// /contacts 
app.get("/contacts", function(req,res){
	Contact.find({},function(err,contacts){
		if(err) return res.json(err);
		res.render("contacts/index",{contacts:contacts});
	});
});
// /contacts/new
app.get("/contacts/new", function(req,res){
	res.render("contacts/new");
});
// /contacts
app.post("/contacts",function(req,res){
	Contact.create(req.body, function(err, contact){
		if(err) return res.json(err);
		res.redirect("/contacts");
	});
});

// 서버실행
app.listen(3000, function(){
	console.log("server on!")
});