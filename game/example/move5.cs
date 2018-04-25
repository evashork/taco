	

	public void Died () 
	{
	    // 로컬포지션
	    transform.localPosition = new Vector3(0 , 0,  0);
	    // 기본포지션
	    transform.position = new Vector3(0 , 0,  0);
	    
	    // position의 경우 바로 값을 대입 할 수 없기 때문에 vector를 만들어서 값을 대입 한다
	    Vector3 temp = transform.position;
	    temp.y = 0;
	    transform.position = temp;
	}

	