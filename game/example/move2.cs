	

	float power = 10f;
	Rigidbody rb;
	bool isJumping = false;

	void Awake ()
	{
		rb = GetCompent<Rigidbody>();
	}

	void Update ()
	{
		if(Input.GetButtonDown("down"))
		{
			isJumping = true;
		}
	}

	void FixedUpdate ()
	{
		Jump();
	}

	void Jump()
	{
		if(!isJumping)
			return;

		rb.velocity = Vector3.zero;

		Vector3 jumpVelocity = new Vector3 (0, power, 0);
		rb.AddForce(jumpVelocity, ForceMode.Impulse);

		isJumping = false;
	}

	void Jump(){
		PS = PlayerState.Jump;
		GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jump_power, 0.0f));
		jumpA = false;
	}

