

	void Awake(){
		StartCoroutine(CheckForControllers());
	}
	
	// MFI controller Setting
	IEnumerator CheckForControllers() 
	{
		while (true) {
			var controllers = Input.GetJoystickNames();
			if (!connected && controllers.Length > 0) {
				connected = true;
				//Debug.Log("Connected");
			} else if (connected && controllers.Length == 0) {
				connected = false;
				//Debug.Log("Disconnected");
			}
			yield return new WaitForSeconds(1f);
		}
	}

	void Update () {

		// mfi controller
		if(Input.GetButtonDown("Retry") || Input.GetKeyDown(KeyCode.Return))
		{
			// Retry
		}

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetAxis ("DHorizontal") > 0 || Input.GetAxis ("Dpad_R") > 0) 
		{
			// Right
		} else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetAxis ("DHorizontal") < 0 || Input.GetAxis ("Dpad_L") > 0) 
		{
			// left	
		}

		if(Input.GetKeyDown(KeyCode.Space) || jumpA || Input.GetButtonDown("MJump")){
			// jump
		}
	}

