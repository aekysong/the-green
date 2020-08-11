using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReplaySceneManager : MonoBehaviour, IInteractable {

    private GameObject inventory;
    public string UnlockItem;
    public Text objectText;

    private void Start()
    {
        inventory = GameObject.Find("Inventory");
        objectText.text = "";
    }

    

    public void Interact(DisplayImage currentDisplay)
    {
        if (GetComponent<BoxCollider2D>().enabled == true)
        {
            objectText.text = "문이 잠겨있습니다";
        }

        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("Unlocked");

            if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name != "knife")
            {
                inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
                inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite
                    = Resources.Load<Sprite>("Inventory Items/empty_item");
            }

            SceneManager.LoadScene("Replay");

        }
    }
}
