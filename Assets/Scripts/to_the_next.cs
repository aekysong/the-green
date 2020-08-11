using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class to_the_next : MonoBehaviour {

    public GameObject showObject;

    private void Start()
    {
        showObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            showObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }


}
