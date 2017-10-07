## Angular

>구글이 만든 단일 페이지 웹어플리케이션 개발을 위한 자바스크립트 프레임워크

- 커스텀 엘리먼츠
- 쉐도우 돔
- HTML Import
- HTML 템플릿

>컴포넌트 기반


- [Angular](https://angular.io/)
- [Angular CLI](https://cli.angular.io/)


### 설치
```
	npm install -g @angular/cli    // Mac에서는 sudo로 설치
```

### Angular CLI 기본명령어
```
	npm install -g @angular/cli    // 
	ng new my-dream-app            // 프로젝트 생성
	ng serve                       // 서버 실행
    ng generate                    // 
    ng help                      
```


### 빌드

```
    ng serve

```

### Module

> 애플리케이션의 주요 부분을 기능단위로 그룹핑한다.

- 모든 애플리케이션은 하나의 Root Module을 가진다.
- 여러 Feature Module을 가질 수 있다.
- 재사용 할 수 있는 기능을 외부에 배포하기 위해 사용되기도 한다.

#### module 생성
```
    ng generate module todo
```

#### component 생성
```
    ng g c todo/todos --module todo/todo.module.ts --export
    ng generate component todo/todos/add-todo –inline-template –inline-style
```

### Component

> Angular 여러개의 component로 구성 된다. 
- HTML 요소들의 그룹
- 뷰와 로직으로 구성

### Templete

> HTML 코드로서 템플릿을 표현

- Template 표현식와 문장을 가짐
- 바인딩


### 테스트

```
    ng test

```



### 배포

```

```



