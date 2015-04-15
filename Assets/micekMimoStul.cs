using UnityEngine;
using System.Collections;

public class micekMimoStul : MonoBehaviour {

	public Transform micekT;
	public Transform respawn;
	void OnTriggerEnter2D(Collider2D micekC){
		if (gameControll.balls > 1) {
			if (micekC.tag == "micek") { 
				gameControll.balls -= 1;
				micekT.position = respawn.position;
			}
		} else if (gameControll.balls == 1) {
			if (micekC.tag == "micek")  
				gameControll.balls -= 1;
		}
	}
}
