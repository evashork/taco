## Javascript wiki



javascript 참고 및 코드 저장소 

- [연산자](#연산자)

- [제어문](#제어문)

  ​

## Debug

```javascript
console.log('hello world')
```



## 기본사용법

### BASIC

```javascript
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

```javascript
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

```javascript
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

```javascript
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

```javascript
var now = new Date();
var greeting = "Good" + ((now.getHours() > 17) ? " evening." : " day.");
```

### 논리연산자

```javascript
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

```javascript
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

```javascript
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

```javascript
for (var i = 0; i < 3; i++){
  console.log(i);
}
```

### while문

반복 횟수를 정확히 알지 못할 때 사용한다.

```javascript
var i = 0;
while (i < 3){
  console.log(i);
  i++;
}
```

### do while문

while문과 매우 유사하나 코드블록은 최소 1회이상 실행된다.

```javascript
var i = 0;
do {
  console.log(i);
  i++;
} while (i < 3);
```

#### break

반복문을 탈출할 때 사용하는 키워드이다. break문을 감싸는 반복문 하나를 탈출한다.

```javascript
var i = 0;
while(1){
  if( i > 3) break;
  console.log("The number is " + i );
  i++;
}
```

#### continue

continue문 이후의 구문은 실행 생략하고 반복문의 조건검사 위치로 이동한다.

```javascript
for (var i =0; i < 5; i++){
  if (i % 2 == 0) continue;
  console.log("The number is " + i);
}
```







