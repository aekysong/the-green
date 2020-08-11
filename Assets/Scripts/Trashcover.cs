using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcover : MonoBehaviour, IInteractable {

    public GameObject[] DisplayObjects;
    public Animator animator;
    private bool Open;

    private float restTime = 0.5f;

    private void Start()
    {
        Open = false;
        for (int i = 0; i < DisplayObjects.Length; i++)
        {
            DisplayObjects[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (Open && restTime > 0f)
        {
            restTime -= Time.deltaTime;
        }

        if (Open && restTime <= 0f)
        {
            for (int i = 0; i < DisplayObjects.Length; i++)
            {
                DisplayObjects[i].SetActive(true);
            }
        }
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (Open == false)
        {
            Open = true;
            animator.SetBool("Open", Open);
        }
    }
}
