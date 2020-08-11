using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class able_collider : MonoBehaviour {

    public GameObject Standard;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Standard.activeSelf)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
