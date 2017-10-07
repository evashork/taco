## firebase



firebase를 알아보자

- [firebase](https://firebase.google.com/?hl=ko)
- [firebase 시작하기](https://firebase.google.com/docs/web/setup?hl=ko)


### 설치
```
	npm install firebase-tools -g
```

### firebase CLI 기본명령어
```
	firebase login			// 로그인
	firebase list			// 프로젝트 목록
	firebase init			// 프로젝트 설정
	firebase serve			// 서버 실행 포트:5000
```


### firebase JSON

```
{
    "hosting": {
        "public": "public",
        "rewrites": [
            {
                "source": "**",
                "destination": "/index.html"
            }
        ]
    }
}
```



### 빌드

```

```



### 테스트

```

```



### 배포

```
    firebase deploy

```



