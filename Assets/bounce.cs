using UnityEngine;
using System.Collections;

public class bounce : MonoBehaviour {
	bool bounced = false;
	public SliderJoint2D guma;
	JointMotor2D j = new JointMotor2D();

	void OnTriggerEnter2D(Collider2D micek){
		if (micek.tag == "micek") { 
			if (bounced == false) {
				j.motorSpeed = -500;
				j.maxMotorTorque = 200;
				bounced = true;
			}
		}
		guma.motor = j;
	}

	void OnTriggerExit2D(Collider2D micek){
		if (micek.tag == "micek") {
			j.motorSpeed = 100;
			j.maxMotorTorque = 200;
			bounced = false;
		}
		guma.motor = j;
	}
}