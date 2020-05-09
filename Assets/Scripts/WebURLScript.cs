using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void btnOne()
    {
        Application.OpenURL("www.google.com");
    }

    public void btnTwo()
    {
        Application.OpenURL("www.bing.com");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
