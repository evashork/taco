## NODE.js wiki
> nodejs와 관련된 개인 위키 및 북마크 및 코드 저장소 입니다. 

* [NPM](#npm)
* [NODE-기본](#node-기본) - node 기본 사용법
* [NODE-객체](#node-객체) - node 기본 객체
* [FileSystem](#filesystem) - 파일처리를 담당하는 node 기본 모듈  
* [EXPERSS](https://github.com/evashork/taco/blob/master/frontend/node/express.md) - 외부 모듈

#### 바로가기

* [Node.js](https://nodejs.org/en/)
* [Node.js API](https://nodejs.org/dist/latest-v6.x/docs/api/)
* [NPM](https://npmjs.com)
* [Node.js 강좌](http://m.blog.naver.com/azure0777/220461355508)
* [Node.js 설치](http://m.blog.naver.com/azure0777/220464281360)
* [node-js-배포-및-운영시-참고사항](http://avilos.codes/server/nodejs/node-js-%EB%B0%B0%ED%8F%AC-%EB%B0%8F-%EC%9A%B4%EC%98%81%EC%8B%9C-%EC%B0%B8%EA%B3%A0%EC%82%AC%ED%95%AD/)
* [RESTful](http://blog.naver.com/azure0777/220508108759)
* [static 정적폴더 설정](http://m.blog.naver.com/azure0777/220469049820)
* [dynamic 동적폴더 설정](http://m.blog.naver.com/azure0777/220475344428)
* [몽고DB 가입 및 설치](http://blog.naver.com/azure0777/220482056110)
* [몽고DB와 몽구스사용법, 모델과 스키마](http://blog.naver.com/azure0777/220482056110)
* [몽고DB API_ find](http://mongoosejs.com/docs/api.html#model_Model.find)

## [Node-기본](#)

#### node 실행
```
node
```

#### test.js 실행
```
node test
```

#### 버전 확인
```
node -v
npm -v
```

## [Node-객체](#)

### 전역변수
```
	console.log('filename:',__filename);	// 현재 실행 중인 코드의 파일 경로를 나타낸다.
	console.log('dirname:',__dirname);		// 현재 실행 중인 코드의 폴더 경로를 나타낸다.
```
### console 객체
```
	console.log();							// 출력
	console.time(label);					// 시간 측정을 시작
	console.timeEnd(label);					// 시간 측정을 종료
```
### process 객체
```
	process.env;							// 컴퓨터 환경과 관련된 정보
	process.version;						// Node 버전
	process.versions;						// Node와 종속된 프로그램 버전
	process.platform;						// 플랫폼을 나타낸다.

	/* process 메서드 */
	process.exit();							// 프로그램을 종료
	process.memoryUsage();					// 메모리 사용 정보를 리턴
	process.uptime();						// 현재 프로그램이 실행된 시간
```
### exports 객체
모듈을 생성할 때는 exports 객체를 사용한다.

#### module.js
```
	exports.abs = function(number) {
		number++;
		return number;
	}
```
#### main.js
```
	var module = require('./module.js');

	module.abs(33);
```


## [npm](#)
> npm은 node 모듈을 쉽게 설치하게 도와주는 프로그램이다.

#### 유용한 npm 모음
* [uglify-js](https://www.npmjs.com/package/uglify-js) - 소스코드 난독화
* [express](https://www.npmjs.com/package/express) - 웹프레임워크
* [jade](https://jade-lang.com) - jade 템플릿
* [nodemon](https://www.npmjs.com/package/nodemon) - node 서버
* [underscore](http://underscorejs.org/) - 배열을 쉽게 사용가능
* [supervisor](https://www.npmjs.com/package/supervisor) - 와치프로그램 소스 변경 감지
* [socket.io](https://www.npmjs.com/package/socket.io) - 실시간 소켓 서버

#### npm init
node 설치하는 명령어, package.json을 생성한다
```
npm init
```
#### -g
npm 설치시 -g 를 붙이면 어디서든 글로벌하게 해당 모듈을 사용하고 불러올 수 있다. -g가 없을 경우는 프로젝트에만 설치 된다.
```
npm install underscore -g
```
#### --save
dependencies 의존성을 package.json에 추가 한다. 프로젝트에 필요한 모듈의 경우엔 --save 붙이는 게 좋다. 일시적으로 사용하는 모듈은  --save를 붙이지 않는다.
```
npm install underscore --save
```
### npm 모음
```
	npm install express
	npm install supervisor -g
	npm install jade --save
	npm install body-parser --save
	npm install multer --save
	npm install underscore --save
	npm install socket.io --save
```

## [FileSystem](#)


#### 모듈 선언
```
	var fs = require('fs');
```

#### 파일 읽기
```
	var fs = require('fs');

	/* 동기적 처리 */
	var text = fs.readFileSync('textfile.txt','utf8');
	console.log(text);

	/* 예외처리 */
	try {
			var text = fs.readFileSync('textfile.txt','utf8');
			console.log(text);
		} catch (e) {
			console.log(e);
	}
	
	/* 비동기적 처리 콜백 */
	fs.readFile('textfile.txt','utf8', function(err,data){
		console.log(data);
	});

	/* 예외처리 */
	fs.readFile('textfile.txt','utf8', function(err,data){
		if(err) {
			console.log(err);
		} else {
			console.log(data);
		}
		
	});

	
```

#### 파일 생성
```
	var fs = require('fs');

	var data = 'Hello world';

	/* 동기적 처리 */
	fs.writeFileSync('textfile3.txt',data,'utf8');
	console.log('WRITE FILE SYNC COMPLETE');

	/* 예외처리 */
	try {
			fs.writeFileSync('textfile3.txt',data,'utf8');
			console.log(text);
		} catch (e) {
			console.log(e);
	}

	/* 비동기적 처리 콜백 */
	fs.writeFile('textfile2.txt', data, 'utf8', function(err){
		console.log('WRITE FILE ASYNC COMPLETE');
	});

	/* 예외처리 */
	fs.writeFile('textfile2.txt', data, 'utf8', function(err){
		if(err) {
			console.log(err);
		} else {
			console.log(data);
		}
		
	});
```




