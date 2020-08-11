using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Brother : MonoBehaviour {

    public Animator animator;
    private bool Dead = false;
    public GameObject[] DisplayObject;

    private float restTime = 0.5f;

    // Use this for initialization
    void Start () {
        Dead = true;
        animator.SetBool("Dead", Dead);
    }

    private void Update()
    {
        if (restTime > 0f)
        {
            restTime -= Time.deltaTime;
        } else
        {
            for (int i = 0; i < DisplayObject.Length; i++)
            {
                DisplayObject[i].SetActive(true);
            }
            
            gameObject.SetActive(false);
        }
    }
}
