using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsManage : MonoBehaviour {

    private DisplayImage currentDisplay;

    public GameObject[] ObjectsToMange;
    public GameObject[] UIRenderObjects;
    public Text restriction;
    public Text conversation;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        RenderUI();
        restriction.enabled = false;
        conversation.enabled = false;
    }

    void Update()
    {
        MangeObjects();
    }

    void MangeObjects()
    {
        for (int i = 0; i < ObjectsToMange.Length; i++)
        {
            if (ObjectsToMange[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                ObjectsToMange[i].SetActive(true);

                if (ObjectsToMange[i].name == "brother_closeup")
                {
                    conversation.enabled = true;
                } else
                {
                    conversation.enabled = false;
                    conversation.text = "";
                }

                if (ObjectsToMange[i].name == "kitchen_wall4")
                {
                    restriction.enabled = true;
                } else
                {
                    restriction.enabled = false;
                    restriction.text = "";
                }
            }
            else
            {
                ObjectsToMange[i].SetActive(false);
            }
        }
    }

    void RenderUI()
    {
        for (int i = 0; i < UIRenderObjects.Length; i++)
        {
            UIRenderObjects[i].SetActive(false);
        }
    }
}
