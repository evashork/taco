	
	
	// 생성
	Instantiate (missile, point.transform.position, point.transform.rotation);
	// 삭제
	Destroy(missile);

	// Use this for initialization
	void Start () {
		// 코루틴 시작하기
		StartCoroutine ("MgMissile" , missileTime);
		// 코루틴 멈추기
		StopCoroutine ("MgMissile");
	}

	IEnumerator MgMissile(float missTime){
		MakeMissile ();

		yield return new WaitForSeconds (missileTime);

		StartCoroutine ("MgMissile");
	}

	void MakeMissile(){
		Rigidbody clone;
            	clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            	clone.AddForce(transform.forward * 5000);

            	Destroy(clone, 1.5f);
	}

	