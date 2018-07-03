## Unity Google Play 연동



#### Plugin

- [Google Play Games plugin for Unity ](https://github.com/playgameservices/play-games-plugin-for-unity) - GPGS



#### 참고

- [(42) 유니티 클리커 게임 한방에 개발하기: 추가편 (완결편) - 안드로이드 / 구글 플레이 서비스 - YouTube](https://www.youtube.com/watch?v=UkafEdb342A&t=3238s)

- [Unity3D에 Google Play Game Service 연동 - 설치편](https://openlevel.postype.com/post/640434)
- [Unity3D에 Google Play Game Service 연동 - 구현편](https://openlevel.postype.com/post/640518) 
- [구글플레이서비스 Unity 연동](http://silisian.tistory.com/104)
- [play-games-plugin-for-unity와 Social API를 이용한 구글 연동 : 네이버 블로그](https://m.blog.naver.com/PostView.nhn?blogId=lsj7915&logNo=221155044823&targetKeyword=unity%20%EC%95%88%EB%93%9C%EB%A1%9C%EC%9D%B4%EB%93%9C%20%EB%9D%BC%EC%9D%B4%EB%B8%8C%EB%9F%AC%EB%A6%AC&targetRecommendationCode=1)



#### 주의사항

- [GPGS 로그인 실패시](http://teraphonia.tistory.com/767) - https://console.cloud.google.com/ 에 인증서 등록
- [GPGS플러그인ForceResolve](http://cafe.naver.com/unityhub/71493) - 해당방법으로 오류해결, 소셜커넥트에서 설정한 플러그인 안드로이드 지워준다.
- GPGS를 설치하면 NativeShare의 arr이 필요없다. 설치가 된다



구글 앱서명에는 업로드 인증서와 앱 서명 인증서가 있다. 업로드 인증서는 유니티에서 keystore를 만들어서 등록해야한다.

만약 하지 않았을 경우 debug.keystore가 업로드 인증서가 된다. apk를 올렸다면 수동으로 바꿀 수 없고 구글에 요청해야 한다.  키스토어는 꼭 백업하여 보관한다.



```c#
// 셋팅
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

// 로그인
PlayGamesPlatform.Activate();
Social.localUser.Authenticate((success, errorMessage)  =>
        {
            if (success)
            {
                Debug.Log("Authentication successful");
                debug.text = "Authentication successful";
                string userInfo = "Username: " + Social.localUser.userName +
                    "\nUser ID: " + Social.localUser.id +
                    "\nIsUnderage: " + Social.localUser.underage;
                Debug.Log(userInfo);
            }
            else
				Debug.Log("Authentication failed" + errorMessage);
        });

// 리더보드 저장


```

