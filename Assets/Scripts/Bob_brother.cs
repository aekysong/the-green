using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bob_brother : MonoBehaviour, IInteractable
{
    public Animator animator;
    private bool Eat, Dead, flag;
    public string UnlockItem;
    public GameObject[] DisplayObject;
    private GameObject inventory;

    private float restTime = 2.8f;

    private void Start()
    {
        Eat = false;
        flag = false;
        inventory = GameObject.Find("Inventory");
        for (int i = 0; i < DisplayObject.Length; i++)
        {
            DisplayObject[i].SetActive(false);
        }
           

    }

    private void Update()
    {

        if (Eat)
        {
            restTime -= Time.deltaTime;
        }
        
    }


    public void Interact(DisplayImage currentDisplay)
    {

        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("Unlocked");
            Eat = true;
            animator.SetBool("Eat", Eat);

            if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name != "knife")
            {
                inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite
                    = Resources.Load<Sprite>("Inventory Items/empty_item");
            }
            
        }

        if (restTime <= 0f)
        {
            gameObject.SetActive(false);

            for (int i = 0; i < DisplayObject.Length; i++)
            {
                DisplayObject[i].SetActive(true);
            }
                
        }

    }
}
