
var ms = 0;
var state = 0;
var nowDate;
var thenDate = new Date();
var mouseTarget;

thenDate.setHours(17);
thenDate.setMinutes(28);
thenDate.setSeconds(0);
thenDate.setMilliseconds(0);

var event = document.createEvent("HTMLEvents");
event.initEvent("click",true,false);

function checkTime(){
  nowDate = new Date();
 
  document.getElementById("date").innerHTML = 
    "<p>" + nowDate.getTime() + "</p>";
  
   document.getElementById("date2").innerHTML = 
    "<p>" + thenDate.getTime() + "</p>";
  
  if(thenDate.getTime() < nowDate.getTime()){
     state = 1;
     mouseTarget.dispatchEvent(event);
  }
}

function hi(){
  alert('예약성공!!')
}

function display(){
  setTimeout("display()",1);
  if(state==1){
    document.getElementById("timer").innerHTML = 
    "<p>스톱</p>"
  }else{
    document.getElementById("timer").innerHTML = 
    "<p>동작 중</p>"
    checkTime();
  }
}

document.onmouseover = function (e){
  var event = e || window.event;
  var target = event.target || event.srcElement;
  mouseTarget = target;
  //console.log(target.getAttribute('id'));
}



