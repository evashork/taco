	
	
	GetComponent<Rigidbody> ().useGravity = true;
	GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
	GetComponent<Collider>().enabled = false;

	GetComponent<SpriteRenderer>().enabled = false;
	GetComponent<Text> ().text = bone.ToString ();
	GetComponent<MeshRenderer> ().material.color = Color.white;
	GetComponent<MeshRenderer> ().material.color = new Color (0, 0, 0);

	gs.GetComponent<GS> ().LifeGS ();
	gs.GetComponent<GS> ().goldCheck;
	GameObject.Find("deathEffect").GetComponent<deathEffect>().Shot(); 

	Canvas canvas = g.AddComponent<Canvas> ();
	Image fadeImg = blackscreen.GetComponent<Image> ();

	