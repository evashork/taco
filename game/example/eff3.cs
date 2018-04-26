using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombEffect : MonoBehaviour {

	List<GameObject> boxList = new List<GameObject>();
	Transform box; 

	float randomX;
	float randomY;
	float randomZ;

	public int minX = -250;
	public int maxX = 250;

	public int minY = 700;
	public int maxY = 755;

	bool isShot = true;

	// Use this for initialization
	void Awake () {
		box = this.transform;

		foreach(Transform boxIn in box){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxList.Add(boxIn.gameObject);
			boxIn.gameObject.transform.localPosition = new Vector3 (0, 0, 0);
			boxIn.gameObject.SetActive(false);
		}
	}

	void Update () {
		if (!isShot) {
			ReadyShot ();
			isShot = true;
		}
	}

	void ReadyShot(){
		foreach(GameObject boxIn in boxList){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트
			boxIn.gameObject.transform.localPosition = new Vector3 (0, 0, 0);
			boxIn.gameObject.SetActive(false);
			boxIn.gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
		}
	}

	void Shot(){
		foreach(GameObject boxIn in boxList){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxIn.gameObject.SetActive(true);
			randomX = Random.Range (minX, maxX);
			randomY = Random.Range (minY, maxY);
			randomZ = 0;
			boxIn.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(randomX, randomY, randomZ));

			//Invoke ("ReadyShot", 0.8f);
		}
	}

	void OnTriggerEnter(Collider collision){
		if(collision.gameObject == player){
			if (isShot) {
				Shot ();
				isShot = false;
			}
		} 
	}
}



