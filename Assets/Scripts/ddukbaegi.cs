using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ddukbaegi : MonoBehaviour, IInteractable
{
    public string UnlockItem;

    public GameObject[] DisappearedObjects;
    public GameObject[] DisplayObjects;
    public GameObject DisappearedObject;

    private GameObject inventory;

    void Start()
    {
        inventory = GameObject.Find("Inventory");
        //for(int i = 0; i < DisplayUnlockedItem.Length; i++)
        //{
        //    DisplayUnlockedItem[i].SetActive(false);
        //}

        for(int i = 0; i < DisappearedObjects.Length; i++)
        {
            DisappearedObjects[i].SetActive(false);
        }
    }

    public void Interact(DisplayImage currentDisplay)
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
                
            for(int i = 0; i < DisplayObjects.Length; i++)
            {
                DisplayObjects[i].SetActive(true);
            }
            gameObject.SetActive(false);
            if (DisappearedObject.activeSelf)
            {
                DisappearedObject.SetActive(false);
            }
            
        }
    }
}
