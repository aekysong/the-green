using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporal_disable : MonoBehaviour {

    public GameObject Hide;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while (gameObject)
        {
            Hide.SetActive(false);
        }
	}
}
