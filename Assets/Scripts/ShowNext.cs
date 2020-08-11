using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNext : MonoBehaviour {

    public GameObject DisplayObject;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.activeSelf)
        {
            DisplayObject.SetActive(true);
        }
	}
}
