using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_bobtong : MonoBehaviour {

    public GameObject[] HideObjects;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < HideObjects.Length; i++)
        {
            HideObjects[i].SetActive(false);
        }
    }

    private void Update()
    {
        for (int i = 0; i < HideObjects.Length; i++)
        {
            HideObjects[i].SetActive(false);
        }
    }

}
