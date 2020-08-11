using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brother : MonoBehaviour, IInteractable
{
    public Animator animator;
    //private bool Hit;
    public string UnlockItem;
    public GameObject[] DisplayObject;
    private GameObject inventory;
    private GameObject brothercloseup;

    private void Start()
    {
        //Hit = false;
        inventory = GameObject.Find("Inventory");
        for (int i = 0; i < DisplayObject.Length; i++)
        {
            DisplayObject[i].SetActive(false);
        }

        brothercloseup = GameObject.Find("brotherCloseup");
        
        
    }

    public void Interact(DisplayImage currentDisplay)
    {
        //if (!Hit)
        //{
        //    Hit = true;
        //    animator.SetBool("Hit", Hit);
        //}
        //else
        //{
        //    Hit = false;
        //    animator.SetBool("Hit", Hit);
        //}

        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("Unlocked");
            if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name != "knife")
            {
                inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite
                    = Resources.Load<Sprite>("Inventory Items/empty_item");
            }

            for (int i = 0; i < DisplayObject.Length; i++)
            {
                DisplayObject[i].SetActive(true);
            }

            
            gameObject.SetActive(false);
            brothercloseup.SetActive(false);
        }


        //if (gameObject == bobbrother)
        //{
        //    if (!Eat)
        //    {
        //        Eat = true;
        //        animator.SetBool("Eat", Eat);
        //    }
        //}
        
    }
}
