using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour, IInteractable
{

    public GameObject DisplayObject;
    public Animator animator;
    private GameObject fire;

    private void Start()
    {
        fire = GameObject.Find("fire");
    }

    private void Update()
    {
        if (gameObject == fire)
        {
            if (gameObject.activeSelf)
            {
                animator.SetBool("Active", gameObject.activeSelf);
            }
        }
        
    }

    public void Interact(DisplayImage currentDisplay)
    {
        DisplayObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
