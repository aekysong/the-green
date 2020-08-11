using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour {

    //public GameObject[] hideThings;
    Canvas m_Canvas;

    private void Start()
    {
        m_Canvas = gameObject.GetComponent<Canvas>();
    }

    // Use this for initialization
    private void Update()
    {
        //if (gameObject.activeSelf)
        //{
        //    for (int i = 0; i < hideThings.Length; i++)
        //    {
        //        hideThings[i].SetActive(false);
        //    }
        //}

        if (gameObject.activeSelf)
        {
            m_Canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            
        } 
    }
}
