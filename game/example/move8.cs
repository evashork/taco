	

	float dir = 1.0f;
	
	void Awake(){

		dir = (transform.localScale.x > 0.0f) ? 1 : -1;
	}

	// Update is called once per frame
	void Update () {

		dir = (transform.localScale.x > 0.0f) ? 1 : -1;
		if(Input.GetKey(KeyCode.RightArrow) || RightA){
			transform.Translate(moveSpeed * Time.deltaTime, 0, 0);

			if(dir < 0){
				transform.localScale = new Vector3(transform.localScale.x * -1.0f, transform.localScale.y, transform.localScale.z);
			}
		}

		if(Input.GetKey(KeyCode.LeftArrow) || LeftA){
			transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
			if(dir > 0){
				transform.localScale = new Vector3(transform.localScale.x * -1.0f, transform.localScale.y, transform.localScale.z);
			}
		}
	}

	