using UnityEngine;
using System.Collections;

public class gameControll : MonoBehaviour {
	public static int score;
	public static int balls;
	public Canvas konecOkno;


	int sizeX= 100;
	int sizeY= 25;
	public int positionY=5;
	void OnGUI () {
		GUI.Box (new Rect (0, 0, sizeX, sizeY), "Body: "+score);
		GUI.Box (new Rect (0,(sizeY+3),sizeX,sizeY), "Míčky: "+ balls);

		if (balls <= 0) {
			Debug.Log("prohral jsi");
			konecOkno.enabled = true;
		}

	}

	void Start () {
		score = 0;
		balls = 1;
		konecOkno.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
