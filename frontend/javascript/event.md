## EVENT

- [UI](#UI)
- [키보드](#키보드)
- [마우스](#마우스)
- [포커스](#포커스)
- [변형](#변형)

### DOM 이벤트 핸들러

> 기본적인 이벤트 사용법
```
	function taco(){
		this.focus();
	}

	var el = document,getElementById('taco');
	el.addEventListener('blur',taco,fasle);

```

고전적인 방법의 이벤트 처리 기법, 한 이벤트 핸들러에 하나의 함수만 바인딩 할 수 있다.
```
	function checkUser(){
		// 사용자의 이름을 체크하는 함수
	}
	var el = document,getElementById('userName');
	
	// 이벤트 앞에 on을 붙인다. 
	// 함수의 ()은 '지금 실행하라' 라는 의미이기 때문에 이벤트가 발생했을 때 실행하기 위해서 ()를 생략한다.
	el.onblur = checkUser;							
```
### 이벤트 리스너
최신 이벤트 처리 기법, 오래된 브라우저에서 지원되지 않는다. IE8이하 사용불가 대신  attachEvent()를 사용한다. 

```
	function checkUser(){
		// 사용자의 이름을 체크하는 함수
	}
	var el = document,getElementById('userName');
	
	// addEventListener('이벤트', 함수, false)
	// 어떤 '이벤트' 가 일어 날 때 지정한 함수를 실행한다. 이벤트 이름은 ''로 감싼다. 일반적으로 false를 사용한다.
	el.addEventListener('blur',checkUser,false);
```

### 매개변수를 가진 이벤트헨들러와 이벤트리스너
```
	el.addEventListener('blur',function(){
		checkUser(5);
	},false);
```

### event 객체
event 객체는 이벤트가 발생할때 마다 해당 이벤트에 대한 정보를 제공한다.
```
	function checkUser(e){
		var target = e.target // 이벤트가 발생한 요소를 가져온다
	}
	var el = document,getElementById('userName');
	el.addEventListener('blur',checkUser,false);
	
	/* 매개변수가 있을 경우 */
	function checkUser(e,minLength){
		var target = e.target // 이벤트가 발생한 요소를 가져온다
	}
	var el = document,getElementById('userName');
	el.addEventListener('blur',function(e){
		checkUser(e,5);
	},false);


```

### [UI](#)
- [load](#load) - 웹페이지의 로드가 완료되었을 때
- [unload](#) - 웹페이지가 언로드될 떄(주로 새로운  페이지를 요청한 경우)
- [error](#) - 브라우저가 자바스크립트 오류를 만났거나 요청한 지원이 존재하지 않는 경우	
- [resize](#) - 브라우저 창의 크기를 조정했을 떄 
- [scroll](#) - 사용자가 페이지를 스크롤할 때

### [키보드](#)
- [keydown](#) - 사용자가 키를 처음 눌렀을 때(키를 눌리는 동안 계속해서 발생)
- [keyup](#) - 사용자가 키를 땔 때 
- [keypress](#) - 사용자가 눌렀던 키의 문자가 입력되었을 떄

### [마우스](#)
- [click](#click) - 마우스 버튼을 눌렀다 뗼 떼
- [dbclick](#) - 마우스 버튼을 두번 눌렀다 뗄 때
- [mousedown](#) - 마우스 버튼을 누르고 있을 떄
- [mouseup](#) - 마우스 버튼을 뗄 때
- [mousemove](#) - 요소 안에서 마우스를 움직일 떄
- [mouseover](#) - 요소 안로 마우스를 움직였을 떄
- [mouseout](#) - 요소 바깥으로 마우스를 움직였을 떄

### [포커스](#)
- [focus](#focus)
- [blur](#)

### [폼](#)
- [input](#) - input 및 textarea 값이 변경 되었을 떄
- [change](#) - 선택 상자, 체크박스, 라디오 버튼의 상태가 변경 되었을 때
- [submit](#) - 사용자가 폼을 제출 할 때
- [reset](#) - 
- [cut](#) - 폼 필드의 컨텐츠를 잘라내기 했을 때
- [paste](#) - 폼 필드의 컨텐츠를 붙여넣었을 떄
- [select](#) - 폼 필드의 텍스트를 선택했을 때

### [변형](#)
- [DOMSubtreeModified](#) - 문서에 변경이 가해졌을 떄
- [DOMNodeInserted](#) - 노드가 다른 노드의 직접적인 자식 노드로 삽입되었을 때
- [DOMNodeRemoved](#) - 노드가 다른 노드에서 제거되었을 때
- [DOMNodeInsertedIntoDocument](#) - 노드가 다른 노드의 자손 노드로 삽입되었을 때
- [DOMNodeRemovedFromDocument](#) - 다른 노드의 자손 노드 중 하나가 제거되었을 때


### [load](#)
```
	function setup(){
		var textInput;
		textInput = document.getElementById('name');
		textInput.focus();
	}

	window.addEventListener('load',setup,false);
```
### [focus](#)
```
	function checkName(){
		var username = el.value;
		if(username.length < 5){
			elMsg.className = 'warning';
			elMsg.textContent = '이름이 너무 짧습니다.'
		}else{
			elMsg.textContent = '';
		}
	}

	function tipName(){
		elMsg.className = 'tip';
		elMsg.innerHTML = '이름은 다섯글자 이상이어야 합니다.';
	}

	var el = document.getElementById('username');
	var elMsg = document.getElementById('feedbook');

	el.addEventListener('focus',tipName,false);
	el.addEventListener('blur',checkName,false);
```

### [click](#)
```
	var msg = '<div class=\"header\"><a id=\"close\" href="#">닫기 X</a></div>';
	msg += '<div class=\"message\"><h2>정기점검 중 입니다.</h2>';
	msg += '오전3시~4시 사이에 점검이 있습니다.';
	msg += '이 시간 동안에는 서비스 이용이 불가능 합니다.</div>'

	var elNote = document.createElement('div');
	elNote.setAttribute('id','note');
	elNote.innerHTML = msg;
	document.body.appendChild(elNote);

	function dismissNote(){
		document.body.removeChild(elNote);
	}

	var elClose = document.getElementById('close');
	elClose.addEventListener('click',dismissNote,false);
```

### [submit](#)
```
	var elForm, elSelect, elHint, elTerms, elTermsHint;
	elForm = document.getElementById('formSignup');
	elSelect = document.getElementById('pakage');
	elHint = document.getElementById('pakageHint');
	elTerms = document.getElementById('terms');
	elTermsHint = document.getElementById('termsHint');

	function pakageHint(){
		var pakage = this.option[this.selectedIndex].value;
		if(pakage == 'monthly') {
			elHint.innerHTML = '1년 패키지를 사용하시면 10불을 절약할 수 있습니다.';
		} else {
			elHint.innerHTML = '탁월한 선택입니다!'
		}
	}

	function checkTime(event){
		if(!elTerms.checked) {
			elHint.innerHTML = '사용권 계약에 동의해야 합니다.';
			event.preventDefault();	// 폼을 전송하지 않는다.
		}
	}

	elForm.addEventListener('submit',checkTime,false);
	elSelect.addEventListener('chage',pakageHint,false);
```







