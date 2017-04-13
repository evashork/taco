## 전역 객체



 ## [String 객체](#string)

- [length](#length) - 문자의 개수를 리턴한다.
- [toUpperCase()](#toUpperCase) - 문자열의 문자를 모두 대문자로 변경한다.
- [toLowerCase()](#toLowerCAse) - 문자열의 문자를 모두 소문자로 변경한다.
- [charAt()](#charAt) - 인덱스 번호를 매개변수로 받아 해당위치의 문자를 리턴한다.
- [indexOf()](#indexOf) - 문자열 내에서 처음 발견된 곳의 인덱스 번호를 리턴한다.
- [lastIndexOf()](#lastIndexOf) - 문자열 내에서 마지막으로 발견된 곳의 인덷그 번호를 리턴한다. 
- [substring()](#substring) - 문자열 내에서 설정한 첫번째 인덱스 번호와 두번째 인덱스 번호에 해당하는 문자의 바로 이전까지 문자를 리턴한다.
- [split()](#split) - 지정된 문자가 나타날 때마다 문자열을 분리한 후 분리한 각각의 문자열로 이루어진 배열을 만들어 리턴한다.
- [trim()](#trim) - 문자열의 양 끝에 있는 공백 문자를 제거한다.
- [replace()](#replace) - 첫번째 인자를 찾아서 두번 째 인자로 바꾼다. 기본적으로 이 동작은 한번만 실행된다.

## [Number 객체](#number)

- [isNaN()]() - 현재 값이 숫자가 아닌지 판단한다.
- [toFixe()]() - 특정 소수점 자리를 발올림한다.
- [toPrecision()]() - 지정된 자릿수까지 반올림한다.
- [toExponential()]() - 숫자를 지수 표기법으로 변환한 문자열을 리턴한다.

## [Math 객체](#math)

- [Math.PI]() - 원주율 값을 리턴한다.
- [Math.round()]() - 숫자를 가장 근접한 정수로 올림/내림 한다.
- [Math.sqrt(n)]() - 양의 제곱근을 리턴한다. 예를 들어 Math.sqrt(9)는 3을 리턴한다.
- [Math.ceil()]() - 지정된 숫자를 자신보다 큰, 가장 가까운 정수로 올림한다.
- [Math.floor()]() - 지정된 숫자를 자신보다 작은, 가장 가까운 정수로 내림한다.
- [Math.random()]() - 0과 1사이의 임의의 숫자를 생성한다. 이때 1은 포함되지 않는다.

## [Date 객체](#date)

- [getDate()]() - 해당 월의 날짜를 리턴한다.
- [setDate()]() - 해당 월의 날짜를 지정한다.
- [getDay()]() - 날짜의 요일을 리턴한다. (0 ~ 6사이의 값을 리턴한다.)
- [getFullYear()]() - 연도를 리턴한다. 
- [setFullYear()]() - 연도를 지정한다. 
- [getHour()]() - 시각을 리턴한다.
- [setHour()]() - 시각을 지정한다.
- [getMilliseconds()] - 밀리초를 




## string

```
var say = "Home sweet home "; 

say.length;             // 16
say.toUpperCase();      // 'HOME SWEET HOME'
say.toLowerCase();      // 'home sweet home'
say.charAt(11);         // 'h'
say.indexOf('ee');      // 7
say.lastIndexOf('e');   // 14
say.substring(8,14);    // 'et hom'
say.split(' ');         // ['home','sweet','home','']
say.trim();             // 'Home sweet home'
say.replace('me','w');  // 'How sweet home '
	
```

## number
```
var orignNum = 10.23456;

orignNum.toFixed(3);     // 10.234
orignNum.toPrecision(3); // 10.2
```

## math
 1부터 10 사이의 임의의 자연수를 생성하기
```
var ranNumber = Math.floor((Math.random() * 10) + 1);	// 1 ~ 10
```