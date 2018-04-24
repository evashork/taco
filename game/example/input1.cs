	if( Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
	{ 
		transform.Translate (0, 0, speed * Time.deltaTime);
	}
	else if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
	{
		transform.Translate (speed * Time.deltaTime, 0 , 0);
	}