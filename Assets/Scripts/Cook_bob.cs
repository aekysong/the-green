using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cook_bob : MonoBehaviour {

    public Animator animator;
    public GameObject DisplayObject;
    private float restTime = 1.2f;

    // Use this for initialization
    void Start()
    {
        if (gameObject.activeSelf)
        {
            animator.SetBool("Cook", true);
        }
    }

    // Update is called once per frame
    void Update()
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
