# git

### git 사이트
- [git](https://git-scm.com/book/ko/v2)
- [cheatsheet](https://rogerdudler.github.io/git-guide/files/git_cheat_sheet.pdf)
- [github를 웹호스팅으로 이용하기 - 생활코딩](https://opentutorials.org/course/2473/16117)

### git 기본사용패턴

```
mkdir taco							# 폴더생성
cd taco								# 폴더이동
git init							# git 설치
git remote add origin <저장소URL>	 # git 원격저장소 추가
git status							# 상태확인
git add .							# 변경사항 추가
git commit -m "변경메세지"			    			# 변경사항 커밋
git push origin master						# 원격저장소 동기화
```



### git설치

```
git init
```



### 상태확인

```
git status
```



### 원격저장소

```
git remote add origin <저장소URL>					# 저장소 추가하기
git clone <저장소URL>						# 저장소 복제하기
```



### 변경사항 추가하기

```
git add 파일이름
git add .							# 변경사항 모두 추가하기
```



### 변경사항 커밋하기

```
git commit -m "변경사항 메모"
git commit -m "전체 변경사항 커밋하기" -a
```



### 원격저장소 동기화

```
git push origin master
```



### Branch

```
git check out -b beta						# 새브런치 만들고 체크아웃
git branch							# 브런치 상태 확인
git add .							# 변경사항 추가
git commit -m "beta 브런치테스트"		 			# 변경사항 커밋
git push -u origin beta						# 브런치 원격저장소 동기화
git check out master						# 마스터로 변경
git branch							# 브런치 상태 확인
git merge beta							# 브런치 합치기
git push							# 원격저장소 동기화
```

### git 에러
#### push가 안될 떄
원격저장소 연결 전 원격저장소에 파일이 있는 경우 동기화가 안되어서 push 가 안됨

```
git check out master
git push origin +HEAD
```