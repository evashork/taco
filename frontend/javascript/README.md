## Javascript wiki



javascript 참고 및 코드 저장소 

- [연산자](#연산자)

- [제어문](#제어문)

- [함수](#함수)

- [객체](#객체)

## Debug

```
console.log('hello world')
```



## 기본사용법

### BASIC

```
// 변수
var age = 30;

var person = "John Doe",
	carName = "Volvo",
	price = 200;

// 함수
function foo() {
  var x = 1, y =2;
  console.log(x + y);
}
foo();

// 객체리터럴
var obj = {
  x: 1,
  y: 2
}
console.log(obj.x + obj.y);
```

### HTML

```html
<!DOCTYPE html>
<html lang="ko">
<body>
	<p id="demo">A Paragraph</p>
	<button type="button" onclick="myFunction()">try it</button>
	<script>
		function myFunction(){
			var myPararaph = document.getElementById("demo");
			myPararaph.innerHTML = "Hello world";
		}
	</script>
</body>
</html>
```



## [연산자](#연산자)

```
var x = 5;
var y = 2;
var z;

z = x + y;	// 7
z = x - y;	// 3
z = x * y;	// 10
z = x / y;	// 2.5
z = x % y;	// 1
z = x++;	// 5 선대입후증가
z = ++x;	// 7 선증가후대입
z = x--;	// 7 선대입후감소
z = --x;	// 5 선감소후대입
```

### 대입연산자

```
var x;

x = 10; // 10
x += 5;	// 15
x -= 5; // 10
x *= 5; // 50
x /= 5; // 10
x %= 5;	// 0

var txt1 = "hello ";
txt1 += "world";		// hello world
```

### 비교연산자

```
var x = 5;

x == 5 		// true
x == '5' 	// true
x === '5'	// false
x !== '5'	// true
x >= 0		// true
x <= 0		// false
```

### 삼항연산자

> 피연산자1 ?  피연산자1 : 피연산자2

피연산자1의 조건식이 참이면 피연사잔의 2의 결과값을 갖고 거짓이면 피연산자3의 결과값을 갖는다.

```
var now = new Date();
var greeting = "Good" + ((now.getHours() > 17) ? " evening." : " day.");
```

### 논리연산자

```
// && AND
var a1 = true && true;		// return true
var a2 = true && false; 	// return false

// || OR
var o1 = true  || false;	// return false
var o2 = false || false; 	// return false 

// ! NOT
var n1 = !true;				// return false;
var n2 = !false;			// return true;
```



## [제어문](#제어문)

### if문

```
var hour = 20;
var greeting;

// if문
if(hour < 10){
  greeting = "Good morning";
} else if(hour < 20){
  greeting = "Good day";
} else {
  greeting = "Good evening";
}


if(document.getElementById('header')){
  // 요소가 존재함
} else {
  // 요소가 존재하지 않음
}
```

### switch문

switch문의 경우, swith변수의 값과 일치되는 case 순으로 실행되며 일치되는 case가 없다면 default로 이동한다.

break는 switch 구문에서 탈출하는 역활을 수행한다. breack가 없다면 실행 순서 다음 case로 이동한다.

```
var color = "red";

switch(color){
  case "apple":
  	console.log("apple is not color");
  case "yellow":
  	console.log("yellow color");
  	break;
  case "red":
  	console.log("red color");
  	break;
  default:
  	console.log("no known color sepcified")
}
```

### for문

가장 일반적인 반복문이다. 일정 횟수만큼 반복 실행하여야 할 때 사용한다.

```
for (var i = 0; i < 3; i++){
  console.log(i);
}
```

### while문

반복 횟수를 정확히 알지 못할 때 사용한다.

```
var i = 0;
while (i < 3){
  console.log(i);
  i++;
}
```

### do while문

while문과 매우 유사하나 코드블록은 최소 1회이상 실행된다.

```
var i = 0;
do {
  console.log(i);
  i++;
} while (i < 3);
```

#### break

반복문을 탈출할 때 사용하는 키워드이다. break문을 감싸는 반복문 하나를 탈출한다.

```
var i = 0;
while(1){
  if( i > 3) break;
  console.log("The number is " + i );
  i++;
}
```

#### continue

continue문 이후의 구문은 실행 생략하고 반복문의 조건검사 위치로 이동한다.

```
for (var i =0; i < 5; i++){
  if (i % 2 == 0) continue;
  console.log("The number is " + i);
}
```

## [함수](#함수)

### 단일 파라미터
```
function calculateArea(width,height){
	var area = width * height;
  return area;
}

var wallOne = calculateArea(3,5);
var wallTwo = calculateArea(8,5);
```

### 복수 파라미터
```
function getSize(width, height, depth) {
	var area = width * height;							// 면적
  var volume = width * height * depth;		// 부피
  var sizes = [area, volume];							// [면적,부피]
  return sizes;
}

var areaOne = getSize(3,2,3)[0];					// size[0] 면적
var areaTwo = getSize(3,2,3)[1];					// size[1] 부피
```

### 익명 함수

자바스크립트 해석기가 표현식을 필요로 하는 곳에 함수를 전달하면 이 함수는 표현식으로 처리되며,
이런 함수를 함수표현식(function expression)이라고 한다. 함수 표현식을 사용할 때는 
대부분 함수 이름을 생략하며, 이처럼 이름이 없는 함수를 익명함수 하고 한다.

```
var area = function(width,height){
	return width * height;
}

var size = area(3,4);
```

###	즉시호출함수표현식

자바스크립트 해석기가 함수정의를 만났을 때 단 한번 실행된다.
익명함수와 즉시호출 함수는 함수를 반복적으로 호출하는 경우가 아니라 작업 내에서 단 한번만 실행 될
필요가 있을 때 사용된다. 

```
(function(){ console.log('hi'); }());

var area = (function(){
	var width = 3;
  var height = 2;
  return width * height;
}());
```

## [객체](#객체)

객체란 변수와 함수를 그룹화한 것을 말한다. 객체 내에서 변수는 속성, 함수는 메서드라고 부른다.

### 객체 생성

```
var hotel = {
  name : 'Quay',							// 속성 = 변수
  rooms : 40,								// 속성 = 변수	
  booked : 25,								// 속성 = 변수
  gym : true,								// 속성 = 변수
  roomTypes : ['트윈','더블','스위트'],			// 속성 = 변수
  checkAvailability : function(){			// 메서드 = 함수
  	return this.rooms - this.booked;
  }
}

// 빈 객체 생성
var hotel = {};								// {} 객체, [] 배열
hotel.name = 'Quey';
hotel.rooms = 40;
hotel.booked = 25;
hotel.checkAvailability = function(){
	return this.rooms - this.booked;
}

```

### 객체 접근하기

```
	var hotelName = hotel.name;
	var hotelName = hotel['name'];
	var roomsFree = hotel.checkAvailability();
```

### 객체 삭제하기
```
	delete hotel.name;		// 속성 제거하기
	hotel.name = '';		// 속성 값 비우기
```

### 생성자 표기법

```
	var hotel = new Object();

```
### 생성자 표기법을 이용한 여러 객체 생성하기

객체 생성자는 함수를 마치 객체 생성을 위한 템플릿처럼 사용한다.

```

	function Hotel(name, rooms, booked){
	  this.name = name;
	  this.rooms = rooms;
	  this.booked = booked;
	  
	  this.checkRoom = function(){
	  	return this.rooms - this.booked;
	  }
	}

	var tacoHotel = new Hotel('Taco',40,20);
	var hiyoHotel = new Hotel('Hiyi',50,11);

	var detail = tacoHotel.name + ' 남은 방: ';
		detail += tacoHotel.checkRoom();
```






