	

	// touch 이벤트 처리
	if (Input.GetMouseButtonDown (0)) 	
	{
		if(EventSystem.current.IsPointerOverGameObject() == false)
		{
			StartPosition = Input.mousePosition;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 1000, 1 << LayerMask.NameToLayer ("layer"))) 
			{
				print("layer");
			} 

			if (Physics.Raycast (ray, out hit, 1000, 1 << LayerMask.NameToLayer ("layer2"))) 
			{
				print("layer2");
				}
			} 
		}
	} 
	// slide 시작
	else if (Input.GetMouseButton (0)) 
	{
			_dx = StartPosition.x - Input.mousePosition.x;
			_dy = StartPosition.y - Input.mousePosition.y;
			swipeDistane = Mathf.Sqrt (Mathf.Pow (_dx, 2) + Mathf.Pow (_dy, 2));
			swipedHorizontal = Mathf.Abs (_dx) > Mathf.Abs (_dy);
			swipedVertical = Mathf.Abs (_dy) > Mathf.Abs (_dx);
	} 
	// slide 끝
	else if (Input.GetMouseButtonUp (0)) 
	{
		//print ("swipeDistane : " + swipeDistane);
		//print (swipedHorizontal);
		if (swipeDistane > swipeDistanceOk) {
			if (swipedVertical && _dy > 0) {
				print("Down");
			} else if (swipedVertical && _dy < 0) {
				print("Up");
			}
		}
		_dx = 0;
		_dy = 0;
		StartPosition = Vector3.zero;
	}

	