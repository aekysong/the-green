using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bobtong : MonoBehaviour, IInteractable {

    public Animator animator;
    private bool Open;
    public GameObject[] DisplayObjects;
    public string UnlockItem;
    private GameObject inventory;
    private GameObject closedBobtong;

    private void Start()
    {
        Open = false;
        inventory = GameObject.Find("Inventory");
        closedBobtong = GameObject.Find("closed_bobtong");

    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (gameObject == closedBobtong)
        {
            if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
            {
                Debug.Log("Unlocked");

                if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name != "knife")
                {
                    inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                    inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite
                        = Resources.Load<Sprite>("Inventory Items/empty_item");
                }

                Open = true;
                animator.SetBool("Open", Open);
                for (int i = 0; i < DisplayObjects.Length; i++)
                {
                    DisplayObjects[i].SetActive(true);
                }
                gameObject.SetActive(false);
            }
        } else
        {
            Open = true;
            animator.SetBool("Open", Open);
            for (int i = 0; i < DisplayObjects.Length; i++)
            {
                DisplayObjects[i].SetActive(true);
            }
            gameObject.SetActive(false);
        }

    }
}
