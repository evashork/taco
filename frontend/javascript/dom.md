# DOM 브라우저 객체 모델

- [접근하기](#접근하기)	- 대상 요소를 표현하는 노드를 찾는다
- [탐색하기](#탐색하기)	- 접근한 노드를 중심으로 다른 요소들을 탐색한다.
- [조작하기](#조작하기) - 노드의 텍스트나 자식 요소 특성들을 조작한다.

## DOM 쿼리 캐싱하기

```
	var itemOne = getElementById('one');
```

## [접근하기](#) 
DOM 쿼리는 하나의 요소를 리턴할 수도 있지만 노드의 모음(collection)인 NodeList를 리턴할 수도 있다.

- [getElementById('id')](#getElementById) - ('id')에 해당하는 id를 찾는다.
- [querySelector('css선택자')](#querySelector) - CSS선택자 문법을 이용하여 요소를 찾는다. 다수 일 경우 첫번째 요소만 리턴한다.
- [getElementsByClassName('클래스이름')](#getElementsByClassName) - class 이름과 같은 모든 요소들을 선택한다.
- [getElementsByTagName('태그이름')](#getElementsByTagName) - 지정된 이름의 태그를 사용하는 모든 요소들을 선택한다.
- [querySelectorAll('css선택자')](#querySelectorAll) - CSS선택자 문법을 이용하여 찾은 모든 요소를 리턴한다.

### NodeList 제어하기
```
	var hotItems = document.querySelectorAll('li.hot');
	for(var i = 0; i < hotItems.length; i++) {
		hotItems[i].className = 'cool';
	}
```

### getElementById
```
	var el = document.getElementById('ond');
	el.className = 'cool';					
```

### querySelector
IE8 이상 가능
```
	var el = document.querySelector('li.hot');

```

### getElementsByClassName

```
	var elements = document.getElementsByClassName('hot');
	if(elements.length >= 1){
		var firstitem = elements[0]
	}
```

### getElementsByTagName

	var elements = document.getElementsByTagName('li');
	if(elements.length > 0){
		var firstitem = elements[0]
	}

### querySelectorAll
IE8 이상 가능
```
	var elements = document.querySelectorAll('li.hot');
	elements[1].className = 'cool';

```

## [탐색하기](#)

- [parentNode](#parentNode) - 부모 요소를  찾는다.
- [previousSibling](#previousSibling) - 이전 노드를 찾는다.
- [nextSibling](#nextSibling) - 다음 노드를 찾는다.
- [firstChild](#firstChild) - 현재 요소의 첫번째 자식요소를 찾는다.
- [lastChild](#lastChild) - 현재 요소의 마지막 자식요소를 찾는다.

```
	var startItem = document.getElementById('two');

	var parItem = startItem.parentNode;
	var preItem = startItem.previousSibling;
	var nexItem = startItem.nextSibling;
	var firItem = startItem.firstChild;
	var lasItem = startItem.lastChild;
```

## [조작하기](#)

- [nodeValue](#nodeValue) - 노드의 값을 수정 및 조회 
- [textContent](#textContent) - 텍스트 값을 수정 및 조회
- [innerHTML](#innerHTML) - HTML 마크업을 수정 및 조회
- [createElement](#createElement) - 요소를 생성한다.
- [createTextNode](#createTextNode) - 콘텐츠를 생성한다.
- [appendChild](#appendChild) - 자식 요소를 추가한다.
- [removeChild](#removeChild) - 자식 요소를 제거한다.
- [getAttribute](#) - 특성 값을 가져온다.
- [hasAttribute](#) - 지정한 특성을 가지고 있는 지 확인한다.
- [setAttribute](#) - 특성에 값을 대입한다.
- [removeAttribute](#) - 특성 값을 제거 한다.

```
	var el = document.getElementById('first');
	var noEl = el.firstChild.nodeValue;
	var txEl = el.textContent;
	var inEl = el.innerHTML;
	inEl = '<h1>' + txEl + '</h1>'; 

	/* DOM 추가하기 */
	var newEl = document.createElement('li');
	var newText = document.ceateTextNode('퀴노아');
	newEl.appendChild(newText);
	var position = document.getElementByTagName('ul')[0];
	position.appendChild(newEl);

	/* 제거하기 */
	var revEl = document.getElementsByTagName('li')[3];
	var containerEl = document.getElementsByTagName('ul')[0];
	containerEl.removeChild(revEl); 

	/* 속성 */
	var firItem = document.getElementById('one');

	if (firItem.hasAttribute('class')){
		var attr = firItem.getAttribute('class');

		if(attr == 'last'){
			firItem.removeAttribute('class');
			firItem.setAttribute('class','first');
		}
	}
```















