var hour = prompt("시간을 입력하세요", "1~24");
var min = prompt("분을 입력하세요","0~59");
var nowDate;
var thenDate = new Date();
var mouseTarget;

var hourInt = Number(hour);
var minInt = Number(min);
thenDate.setHours(hourInt);
thenDate.setMinutes(minInt);
thenDate.setSeconds(0);
thenDate.setMilliseconds(0);

var x = setInterval (checkTime, 1);
var event = document.createEvent("HTMLEvents");

event.initEvent("ondbclick",true,false);

function checkTime() {
  nowDate = new Date();
  if(thenDate.getTime() < nowDate.getTime()){
     mouseTarget.dispatchEvent(event);
     clearInterval(x);
  }
}

document.onmouseover = function (e){
  var event = e || window.event;
  var target = event.target || event.srcElement;
  mouseTarget = target;
}
