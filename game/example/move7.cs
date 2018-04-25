
	public float rotateSpeed = 100f;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0, rotateSpeed * Time.deltaTime, 0);
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0, -rotateSpeed * Time.deltaTime, 0);
		} 

		Debug.Log (transform.rotation.y);
		Debug.Log (transform.eulerAngles.y);
	}