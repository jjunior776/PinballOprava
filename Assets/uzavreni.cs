using UnityEngine;
using System.Collections;

public class uzavreni : MonoBehaviour {
	public HingeJoint2D zarazka;
	JointMotor2D j = new JointMotor2D();



	void OnTriggerEnter2D(Collider2D micek){
		if (micek.tag == "micek") { 
				j.motorSpeed = -500;
				j.maxMotorTorque = 1000;
		}
		zarazka.motor = j;
	}
	
	void OnTriggerExit2D(Collider2D micek){
		if (micek.tag == "micek") {
			j.motorSpeed = 500;
			j.maxMotorTorque = 1000;
		}
		zarazka.motor = j;
	}
}
