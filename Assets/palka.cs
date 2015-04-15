using UnityEngine;
using System.Collections;

public class palka : MonoBehaviour {

	bool otevreno=false;
	public KeyCode klavesa;
    public int mirroring = 1;

    HingeJoint2D hj;
	JointMotor2D j = new JointMotor2D();
	// Use this for initialization
	void Start () {
	    hj = gameObject.GetComponent<HingeJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
		hj.motor = j;
		if((Input.GetKey(klavesa))){
            
            j.motorSpeed = -2000*mirroring;
            j.maxMotorTorque = 10000;
            //hj.motor = j;
			otevreno=true;
		}else{
            j.motorSpeed = 2000*mirroring;
            j.maxMotorTorque = 10000;
            //hj.motor = j;
			otevreno=false;
		}
        //Debug.Log(klavesa +" "+ Input.GetKey(klavesa) + " force: " + hj.motor.motorSpeed);

	}
}
