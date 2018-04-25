

	// OnTriggerEnter
	// OnTriggerExit
	// OnTriggerStay
	
	GameObject player;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter(Collider col){
	
		if(col.gameObject == player){
			Vector3 point = new Vector3();
			point.x = 0.1f;
			point.y = 0.2f;
			point.z = 0f;

			player.transform.position = point;
		}

	}

	void OnTriggerExit (Collider col) {
	
	}

