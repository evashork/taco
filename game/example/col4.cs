

	GameObject player;
	bool moveOn = false;
	float moveSpeed = 4f; 

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject == player) {
			moveOn = true;
		}
	}

	// transform.parent 
	void Update(){
		if (moveOn && transform.parent.position.y > -4.5) {
			transform.parent.Translate (0, -moveSpeed * Time.deltaTime, 0);
		}
	}

