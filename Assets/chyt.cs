using UnityEngine;
using System.Collections;

public class chyt : MonoBehaviour {

	public Transform micekT;
	public Transform zastavka;
	public Rigidbody2D micekR;
	bool cekam=false;

	void OnTriggerEnter2D(Collider2D micekC){
		
		if (cekam == false){
			if (micekC.tag == "micek") {
				StartCoroutine ("wait");
			}
		}
	}

	IEnumerator wait(){
		cekam = true;
		micekT.position = zastavka.position;
		micekR.isKinematic = true;
		Debug.Log ("cekam");
		yield return new WaitForSeconds(1);
		Debug.Log ("docekal jsem");
		micekR.isKinematic = false;
		float randomY = Random.value * 0.2f;
		micekR.AddForce(new Vector2(0.1f,(randomY-0.1f)));
	}

	void OnTriggerExit2D(Collider2D micekC){
		if (micekC.tag == "micek") {
			gameControll.balls+=1;
			cekam=false;
		}

	}

}
