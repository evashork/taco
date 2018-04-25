	
	
	GameObject test;	
	GameObject player;  
	GameObject[] deathzone; // 여러개의 오브젝트 가져오기

	void Awake()
	{
		test = GameObject.Find("이름"); 						// 이름으로 찾기
		player = GameObject.FindGameObjectWithTag ("Player");			// 태그로 찾기
		deathzone = GameObject.FindGameObjectsWithTag ("deathzone"); 		// 태그로 다수의 오브젝트 찾기

		foreach(GameObject deathzoneEach in deathzone){  			// 다수의 오브젝트 컴포넌트를 각각 비활성화
			deathzoneEach.GetComponent<SpriteRenderer>().enabled = false;
		}

		// 이름으로 찾기 활용
		tempObj = GameObject.Find("Monster" + monsterNumber.ToString());

		if(tempObj != null)
		{
			// 확인
		} else
		{	
			// 없음
		}
	}	

	