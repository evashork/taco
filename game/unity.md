## Unity

> Unity 기본 사용법 

### 바로가기
- [조작](#조작)
/ [이동](#이동)
/ [충돌](#충돌) 
/ [ETC](#ETC)
/ [접근](#접근)
/ [관계](#관계)
/ [저장](#저장)
/ [복제](#복제)

### 참고사이트
- [Unity](https://unity3d.com/kr/) 공식사이트
- [C#]()


### <a name="조작">조작</a>
### <a name="이동">이동</a>
### <a name="충돌">충돌</a>
### <a name="ETC">ETC</a>
[Coroutines]()
[SendMessage]()
### <a name="접근">접근</a>
### <a name="관계">관계</a>
### <a name="저장">저장</a>
### <a name="복제">복제</a>






## 디렉토리

```
	ls				* 파일 보기
	ls -l				* 파일 상세보기
	ls -l 폴더명			* 특정 폴더 파일보기

	cd .. 				* 이동
	pwd				* 경로 확인

	mkdir 폴더명			* 디렉토리 생성
	rmdir 폴더명			* 디렉토리 삭제
	rm -r 폴더명 			* 디렉토리 삭제 (파일까지 삭제)
	cp -r 폴더1 폴더2			* 디렉토리 복사

	mv /home/etc/ /home/hi/		* 파일 이동 - etc 폴더를 hi 이동	 (폴더 url은 pwd로 확인)
```

## 파일

```
	touch 파일명			* 파일 생성

	mv ./hi.md /taco/		* 파일 이동 (폴더 url은 pwd로 확인)
	mv data1 data2			* 파일 이름 변경

	cp copy.md past.md		* 파일 복사 

	rm 파일명				* 파일 삭제

	cat 파일명			* 파일 보기
	head 파일명			* 파일 보기 (처음 10줄)
	tail 파일명			* 파일 보기 (마지막 10줄)
```


## ETC

```
	find				* 검색
	tar				* 파일 묶음
	ls -al | wc -l			* | 명령의 결과를 다음 명령의 입력으로 넘긴다
	grep				* 파일에 포함된 특정 단어를 검색
```