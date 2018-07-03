# Unity Native Share



#### Plugin

- [unity-native-sharing: A Unity plugin to open native sharing dialogs on iOS and Android, primarily for sharing screenshots.](https://github.com/gmikhail/unity-native-sharing)
- [anchan828 / social-connector](https://github.com/anchan828/social-connector) 



#### 사용시 주의 사항

- 안드로이드의 경우 arr 파일이 필요하다. Plugins > anrdorid 에 arr 파일을 넣어준다.
- 안드로이드 빌드 오류 시 target API Level 을 맞춰준다. 24이상은 FileProvider 사용이 필수이다.
- arr파일 4개가 필요한데 GPGS 구글플레이연동 플러그인을 설치하면 자동으로 설치된다. 따라서 GPGS 작업 후  Native Share를 진행한다. 