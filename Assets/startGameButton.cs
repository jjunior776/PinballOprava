using UnityEngine;
using System.Collections;

public class startGameButton : MonoBehaviour {
    [SerializeField] UnityEngine.UI.Button butt = null;
	// Use this for initialization
	void Start () {
	   butt.onClick.AddListener(() => startGame()); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void startGame(string level = "first_level")
    {
        Application.LoadLevel(level);



    }
}
