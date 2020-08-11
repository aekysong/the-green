using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prolog : MonoBehaviour {

    public Animator animator;
    private float restTime = 16.0f;
    public GameObject DisplayObject;

    // Use this for initialization
    void Start () {
		
	}

    private void Update()
    {
        if (restTime > 0f)
        {
            restTime -= Time.deltaTime;
        }
        else
        {
            DisplayObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
