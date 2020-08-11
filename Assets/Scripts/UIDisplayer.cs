using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplayer : MonoBehaviour, IInteractable
{
    public GameObject DisplayObject;
    public GameObject[] DisappearObjects;

    public GameObject[] Objects;

    void Start()
    {
        DisplayObject.SetActive(false);

        for (int i = 0; i < Objects.Length; i++)
        {
            Objects[i].SetActive(false);
        }
    }

    void Update()
    {
        if (!DisplayObject.activeSelf)
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                if (Objects[i])
                {
                    Objects[i].SetActive(false);
                }
            }

            for (int i = 0; i < DisappearObjects.Length; i++)
            {
                DisappearObjects[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                if (Objects[i])
                {
                    Objects[i].SetActive(true);
                }
            }

            for (int i = 0; i < DisappearObjects.Length; i++)
            {
                DisappearObjects[i].SetActive(false);
            }
        }
    }

    public void Interact(DisplayImage currentDisplay)
    {
        
        if (DisplayObject.activeSelf)
        {
            DisplayObject.SetActive(false);
            for (int i = 0; i < Objects.Length; i++)
            {
                
                if (Objects[i])
                {
                    Objects[i].SetActive(false);
                }
            }

            for (int i = 0; i < DisappearObjects.Length; i++)
            {
                DisappearObjects[i].SetActive(true);
            }


        }
        else
        {
            DisplayObject.SetActive(true);
            for (int i = 0; i < Objects.Length; i++)
            {
                if (Objects[i])
                {
                    Objects[i].SetActive(true);
                }
            }
            for (int i = 0; i < DisappearObjects.Length; i++)
            {
                DisappearObjects[i].SetActive(false);
            }
        }
    }
    }

