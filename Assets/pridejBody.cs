using UnityEngine;
using System.Collections;

public class pridejBody : MonoBehaviour {
	public int scoreValue;

	void OnCollisionEnter2D(Collision2D micek){
		if (micek.gameObject.tag == "micek") { 
			gameControll.score+= scoreValue;
		}

	}
}
