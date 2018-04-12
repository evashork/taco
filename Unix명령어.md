## Unix 기본 명령어

> 기본적인 Unix 명령어 

- [기본 명령어](http://cailisin.tistory.com/entry/리눅스-Linux-유닉스-Unix-주요-기본-명령어)
- [권한 관리](http://cailisin.tistory.com/entry/유닉스-Unix-리눅스-Linux-권한-관리)
- [사용자 및 그룹관리](http://cailisin.tistory.com/entry/유닉스-Unix-리눅스-Linux-사용자-및-그룹-관리)

## 디렉토리

```
	ls						* 파일 보기
	ls -l 					* 파일 상세보기
	ls -l 폴더명				* 특정 폴더 파일보기

	cd .. 					* 이동
	pwd						* 경로 확인

	mkdir 폴더명				* 디렉토리 생성
	rmdir 폴더명				* 디렉토리 삭제
	rm -r 폴더명 				* 디렉토리 삭제 (파일까지 삭제)
	cp -r 폴더1 폴더2			* 디렉토리 복사

	mv /home/etc/ /home/hi/	* 파일 이동 - etc 폴더를 hi 이동	 (폴더 url은 pwd로 확인)
```

## 파일

```
	touch 파일명				* 파일 생성

	mv ./hi.md /taco/		* 파일 이동 (폴더 url은 pwd로 확인)
	mv data1 data2			* 파일 이름 변경

	cp copy.md past.md		* 파일 복사 

	rm 파일명					* 파일 삭제

	cat 파일명				* 파일 보기
	head 파일명				* 파일 보기 (처음 10줄)
	tail 파일명				* 파일 보기 (마지막 10줄)
```


## ETC

```
	find					* 검색
	tar						* 파일 묶음
	ls -al | wc -l			* | 명령의 결과를 다음 명령의 입력으로 넘긴다
	grep					* 파일에 포함된 특정 단어를 검색
```
