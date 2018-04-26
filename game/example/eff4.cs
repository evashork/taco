using UnityEngine;
using System.Collections;
using System.Collections.Generic; // list 
public class shotCOD : MonoBehaviour {

	List<GameObject> shotList = new List<GameObject>();
	Transform shot; 
	GameObject gs;

	public float shotTime = 5.0f;
	int shotI = 0;
	int shotX = 0;

	bool triggerShot;

	void Start(){
		gs = GameObject.FindGameObjectWithTag ("gs");
		shot = this.transform;

		foreach(Transform ShotIN in shot){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			shotList.Add(ShotIN.gameObject);
			ShotIN.gameObject.SetActive(false);
		}

		shotX = shotList.Count;

		triggerShot = false;
	}

	void Update(){
		if(gs.GetComponent<GS>().GT == GameState.Start){
			if(!triggerShot){
				TriggerStart (shotList);		
			}
		}

		if (gs.GetComponent<GS> ().GT == GameState.Stop) {
			ShotDown ();
		}

		if (gs.GetComponent<GS> ().GT == GameState.Ready) {
			TriggerStop (shotList);
			ShotDown ();
		}
	}

	void TriggerStart(List<GameObject> shotNumList){
		for(int i = 0; i < shotNumList.Count; i++){ 
			shotNumList [i].GetComponent<hitCOD> ().Reload ();
		}
		StartCoroutine (ShotCOD(shotList));
		triggerShot = true;
	}

	void TriggerStop(List<GameObject> shotNumList){
		for(int i = 0; i < shotNumList.Count; i++){
			shotNumList [i].GetComponent<hitCOD> ().Reload ();
		}
	}
		
	void ShotUp(GameObject bullet){
		bullet.SetActive (true);
	}

	void ShotDown(){
		shotI = 0;
		StopAllCoroutines ();
        	TriggerStop(shotList);
		triggerShot = false;
	}
		
	IEnumerator ShotCOD(List<GameObject> shotNumList){
		// 미사일을 5초마다 쏜다
		ShotUp (shotNumList[shotI]);

		if (shotI < shotX) {
			shotI++;
		}

		if(shotI == shotX){
			shotI = 0;
		}

		yield return new WaitForSeconds (shotTime);

		if(gs.GetComponent<GS>().GT == GameState.Start){
			// 미사일을 쏜다
			StartCoroutine (ShotCOD(shotList));
		}
	}
}
