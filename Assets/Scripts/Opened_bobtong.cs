using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opened_bobtong : MonoBehaviour, IInteractable
{

    public string UnlockItem;
    private GameObject inventory;
    public GameObject DisplayObject;
    public GameObject[] HideObjects;

    private void Start()
    {
        inventory = GameObject.Find("Inventory");
        DisplayObject.SetActive(false);

        
    }

    private void Update()
    {
        for (int i = 0; i < HideObjects.Length; i++)
        {
            HideObjects[i].SetActive(false);
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

            DisplayObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
