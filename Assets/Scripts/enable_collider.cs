using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enable_collider : MonoBehaviour {

    public GameObject Standard;


    private void Start()
    {
        
    }


    private void Update()
    {
        if(Standard.activeSelf)
        {
            GetComponent<BoxCollider2D>().enabled = false;
        } else
        {
            GetComponent<BoxCollider2D>().enabled = true;
            
        }

        if (Standard.GetComponent<PickUpItem>().IsDestroy)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

}
