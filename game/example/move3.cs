	

	public Vector2 startXY;
	public Vector2 endXY;
	public float moveSpeed; 
	public bool leftRight = true;   

	float dir = 1.0f;

	// Use this for initialization
	void Awake () {
	}
	
	// Update is called once per frame
	void Update () {

		int stringX = Mathf.RoundToInt (transform.position.x);
		int stringY = Mathf.RoundToInt (transform.position.y);
	
		if(leftRight){
			if (stringX == startXY.x) {
				dir = 1.0f;
			} else if(stringX == endXY.x){
				dir = -1.0f;
			}
			transform.Translate (moveSpeed * Time.deltaTime * dir, 0, 0);
		}else{
			if (stringX == startXY.x) {
				dir = -1.0f;
			} else if(stringX == endXY.x){
				dir = 1.0f;
			}
			transform.Translate (moveSpeed * Time.deltaTime * dir, 0, 0);
		}
	}

	