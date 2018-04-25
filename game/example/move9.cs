

	void MoveCod () {
	  Vector3 toPlayerDir = 
	  player.transform.position - new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z);

	  //this.GetComponent<Rigidbody> ().AddForce (toPlayerDir.normalized * 100.0f);
	  transform.Translate (toPlayerDir.x, 0, 0);
	}

