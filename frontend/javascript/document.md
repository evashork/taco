## DOCUMENT 객체



 문서 객체 모델 (DOM)의 최상위 객체는 document 객체이다.
 이 객체는 현재 브라우저 창 또는 탭에 로드된 웹페이지를 표현한다.


- [document.title](#) - 현재 문서의 제목
- [document.lastModified](#) - 현재 문서가 가장 마지막으로 수정된 날짜
- [document.URL](#) - 현재 문서의 URL을 문자로 리턴한다.
- [document.domain](#) - 현재 문서의 도메인을 리턴한다.

- [document.write()](#) - 문서에 텍스트를 출력한다.
- [document.getElementById()](#) - id 특성 값이 일치하는 요소가 존재하면 해당 요소를 리턴한다.
- [document.querySelectorAll()](#) - 매개변수로 전달된 CSS 선택자와 일치하는 요소의 목록을 리턴한다.
- [document.createElement()](#) - 새로운 요소를 생성한다.
- [document.createTextNode()](#) - 새로운 텍스트 노드를 생성한다.


### DOCUMENT 기본 예제

```
	var msg = '<p>페이지 제목 ' + document.title + '<br/>';
	msg += '페이지 주소 : ' + document.URL + '<br/>';
	msg += '최종수정일 : ' + document.lastModified + '<br/>';

	(function(){ 
		var el = document.getElementById('studyHard');
	  el.innerHTML = msg;
	}());
``` 