

	public Transform target;
	public float speed = 5.0f;
	Vector3 movement;

	void Update () 
	{
        	movement = target.transform.position;
        	transform.RotateAround(movement, Vector3.up, speed * Time.deltaTime);
	}


