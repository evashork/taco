

	// OnCollisionEnter
	// OnCollisionExit
	// OnCollisionStay

	// 3D
	void OnCollisionEnter(Collision col){
		Vector3 pos = col.contacts [0].point;
		print (pos);
	}

	// 2D
	void OnCollisionEnter2D(Collision2D col){
		Vector3 pos = col.contacts [0].point;
		print (pos);
	}

