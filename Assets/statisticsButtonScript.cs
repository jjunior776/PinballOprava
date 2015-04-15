using UnityEngine;
using System.Collections;

public class statisticsButtonScript : MonoBehaviour {
    [SerializeField] UnityEngine.UI.Button butt = null;
	// Use this for initialization
	void Start () {
        butt.onClick.AddListener(() => goToStatistics());  
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void goToStatistics()
    {
      //  Application.LoadLevel("statistics"); //TODO udělat statistics level
    }
}
