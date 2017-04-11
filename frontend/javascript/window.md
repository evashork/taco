## WINDOW 객체



 window 객체의 주요 속성과 메서드 

- [window.innerHeight](#innerHeight) - 창의 높이 픽셀 (브라우저 창 테두리 및 사용자 인터페이스 부분은 제외)
- [window.innerWidth](#innerWidth) - 창의 너비 픽셀 (브라우저 창 테두리 및 사용자 인터페이스 부분은 제외)
- [window.pageXOffset](#pageXOffset) - 문서의 가로 스크롤 크기
- [window.pageYOffset](#pageYOffset) - 문서의 세로 스크롤 크기
- [window.screenX](#screenX) - 화면의 좌측상단으로부터 현재 마우스 포인터의 X 좌표
- [window.screenY](#screenY) - 화면의 좌측상단으로부터 현재 마우스 포인터의 X 좌표
- [window.location](#location) - window 객체의 현재 URL
- [window.document](#document) - 현재 창에 로드 된 페이지를 표현하는 document 객체에 대한 참조
- [window.history](#history) - 현재 창이나 탭을 통해 로드되었던 페이지들의 상세 정보를 제공
- [window.history.length](#history.length) - 브라우저 나 탭에 보관된 페이지 개수
- [window.screen](#screen)	- screen 객체에 대한 참조
- [window.screen.width](#screen.width)	- 모니터의 넓이
- [window.screen.height](#screen.height) - 모니터의 높이
- [window.alert()](#alert) - 메세지를 포함하는 대화상자
- [window.open()](#open) - 매게변수로 지정된 URL을 표시하는 새로운 브라우저 창을 생성
- [window.print()](#print) - 현재 페이지를 인쇄



# open

```
var windowURL = window.location;

/* test */
(function(){ 
	window.open(windowURL)
}());
```