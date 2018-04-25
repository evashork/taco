	

	GameObject.Find("Box").SendMessage("Method");
	
	void ApplyDamage(float damage) {
		print(damage);
	}

	void Example() {
		SendMessage("ApplyDamage", 5.0F);
	}

	void OnTriggerEnter(Collider coll)
	{
		coll.SendMessage("ApplyDamage", 5.0F, SendMessageOptions.DontRequireReceiver);
	}
	



	