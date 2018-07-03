## Unity iOS GameCenter



### 설치

```c#
using UnityEngine.SocialPlatforms;
```



### 기능

##### 로그인

- Social.localUser.authenticated - 로그인 확인
- Social.localUser.Authenticate() - 로그인 창 열기

##### 리더보드

- Social.ShowLeaderboardUI() - 리더보드 열기 
- Social.ReportScore(score, boardID, func) - 점수 업데이트
- Social.LoadScores() - 리더보드 정보 가져오기

##### 업적

- Social.ShowAchievementUI() - 업적 열기
- Social.ReportProgress(id,progress,func) - 진행율 업데이트
- Social.LoadAchievements() - 업적 가져오기



### Example

```c#
using UnityEngine;
 
public class SocialAPI : MonoBehaviour
{
    void Start ()
    {
        if (!Social.localUser.authenticated)
            Social.localUser.Authenticate (success => {
                //do something on success if you like
                });
    }
    
    public void Hi()
    {
		if (Social.localUser.authenticated)
        {
#if UNITY_IPHONE
			Social.ReportScore(gCount, "g_count", null);
#elif UNITY_ANDROID
			Social.ReportScore(gCount, "leaderboard_g_count", success => { debugtxt.text = "g count"; });
#endif
        }
        else
        {
            Social.localUser.Authenticate(success =>
            {
                if (success)
                {
#if UNITY_IPHONE
					Social.ReportScore(gCount, "g_count", null);
#elif UNITY_ANDROID
					Social.ReportScore(gCount, "leaderboard_g_count", result => { debugtxt.text = "g count2"; });
#endif
                }
            });
        }
    }
    		
 
    public void ShowLeaderboard ()
    {
        if (Social.localUser.authenticated)
        {
            Social.ShowLeaderboardUI();
        }
        else (!Social.localUser.authenticated){
			Social.localUser.Authenticate(success =>
			{
				Social.ShowLeaderboardUI();
			});
		}
    }
 
    public void ReportScoreToLeaderboard ()
    {
        if (Social.localUser.authenticated) {
            Social.ReportScore ("integer data to be sent", leaderboardID, success => {
                if (success)
                    Social.ShowLeaderboardUI ();
            });
        }
    }
}
```

