

	void Update () {

		rayPoint = transform.position;
		rayPoint.y += 0.5f;
		Debug.DrawRay (rayPoint, this.transform.right  * -1.0f * rayRange, Color.red);

		RaycastHit hit;

		if (Physics.Raycast (rayPoint, this.transform.right, out hit, rayRange)) {
			if (hit.collider.gameObject.tag == "wall") {
				wallCheck = true;
			} else {
				wallCheck = false;
			}
		} 

		if (!wallCheck){
			transform.Translate (speed * Time.deltaTime, 0, 0);
		}


		if(dir < 0){
			transform.localScale = new Vector3(transform.localScale.x * -1.0f, transform.localScale.y, transform.localScale.z);
		}
	}

