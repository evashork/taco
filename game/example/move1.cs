
	
	float speed = 10f;
	Vector3 movement;

	void FixedUpdate ()
	{
		Move();
	}

	void Move()
	{
		movement = Vector3.zero;

		if(Input.GetAxisRaw("Horizontal") < 0)
		{
			movement = Vector3.left;
		}
		else if(Input.GetAxisRaw("Horizontal") > 0)
		{
			movement = Vector3.right;
		}

		tranform.position += movement * speed * Time.deltaTime;
	}

