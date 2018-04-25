	

	GameObject test;	
	GameObject player;  
	GameObject tempObj;

	void Awake()
	{
		test.transform.Find("taco");						// 이름으로 자식 찾기
            	player.transform.GetChild(18);						// 번호로 자식 찾기	
            						
		// 이름으로 자식 찾기 활용
		tempObj = GameObject.Find("Monsters").transform.Find("Monster" + monsterNumber.ToString()).gameObject;
		// 번호로 자식 찾기 활용
		tempObj = GameObject.Find("Monsters").transform.GetChild(monsterNumber-1).gameObject;

		if(tempObj != null)
		{
			// 확인
		} else
		{	
			// 없음
		}
	}	

	