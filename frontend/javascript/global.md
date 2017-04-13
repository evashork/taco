## 전역 객체



 ## [string](#stirng객체)

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

## string객체

```
	var say = "Home sweet home "; 
	
	say.length;				// 16
	say.toUpperCase();		// 'HOME SWEET HOME'
	say.toLowerCase();		// 'home sweet home'
	say.charAt(11);			// 'h'
	say.indexOf('ee');		// 7
	say.lastIndexOf('e');	// 14
	say.substring(8,14);	// 'et hom'
	say.split(' ');			// ['home','sweet','home','']
	say.trim();				// 'Home sweet home'
	say.replace('me','w');	// 'How sweet home '
	
```