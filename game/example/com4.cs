	

	GameObject player;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject == player){
			print ("Enter");
			player.transform.SetParent(this.transform);  // player를 자식으로 설정
			// transform.SetParent(player.transform)
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject == player){
			print ("Exit");
			transform.DetachChildren(); // 자식설정을 헤체
		}
	}

	