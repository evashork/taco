# Heroku에서 node.js 프로젝트 실행하기

## 참고링크
- [HEROKU](https://www.heroku.com/)
- [HEROKU CLI](https://devcenter.heroku.com/articles/heroku-cli) - heroku 관리 도구 반드시 설치!!!
- [Heroku with Node.js](https://devcenter.heroku.com/articles/getting-started-with-nodejs) - heroku 공식가이드

## 바로가기
-[]

## Heroku git
Heroku는 git을 통해 배포 및 수정한다.
```
git add .						- 변경사항 추가	
git commit -m "변경사항 메모"		- 변경사항 커밋
git push heroku master			- 저장소 동기화
```

## Heroku 로그인

```
heroku login
```

## Heroku Clone
```
git clone https://github.com/heroku/node-js-getting-started.git heroku-express-example
cd heroku-express-example  -- 생성 후 이동
```

## Heroku Deploy the App
app을 Heroku에 생성한다. https://h-socket.herokuapp.com/ 
```
heroku create h-socket
```
#### git 동기화
```
git push heroku master
```

## NPM 설치
```
npm install
```

## 로컬에서 실행
```
heroku local web
```
