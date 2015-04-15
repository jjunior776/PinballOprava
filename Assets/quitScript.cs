using UnityEngine;
using System.Collections;

public class quitScript : MonoBehaviour {

    [SerializeField]
    UnityEngine.UI.Button butt = null;
    // Use this for initialization
    void Start()
    {
        butt.onClick.AddListener(() => quit());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void quit()
    {
        Application.Quit();



    }
}
