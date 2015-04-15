using UnityEngine;
using System.Collections;

public class buttonControll : MonoBehaviour {
	public UnityEngine.UI.InputField jmenoText;
	public string jmeno;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void menu(){
		Application.LoadLevel ("menu");
	}
	
	public void zapisSkore(){
		jmeno = jmenoText.text;


		Application.LoadLevel ("menu");
	}
}
