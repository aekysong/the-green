using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public GameObject currentSelectedSlot { get; set; }
    public GameObject previousSelectedSlot { get; set; }

    private GameObject slots;
    public GameObject itemDisplayer { get; private set; }
    private GameObject[] openThings;

    private GameObject text;

    //Canvas m_Canvas;

    private void Start()
    {
        InitializeInventory();
        //openThings = itemDisplayer.GetComponent<Recipe>().hideThings;
        //m_Canvas = itemDisplayer.GetComponent<Canvas>();
        text = GameObject.Find("TextManager");
    }

    private void Update()
    {
        SelectSlot();
        HideDisplay();
    }

    void InitializeInventory()
	{
        slots = GameObject.Find("Slots");
        itemDisplayer = GameObject.Find("ItemDisplayer");
        itemDisplayer.SetActive(false);

        foreach (Transform slot in slots.transform)
		{
			slot.transform.GetChild(0).GetComponent<Image>().sprite =
				Resources.Load<Sprite>("Inventory Items/empty_item");
            slot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
		}
        currentSelectedSlot = GameObject.Find("slot (7)");
        previousSelectedSlot = currentSelectedSlot;
	}

    void SelectSlot()
    {
        foreach(Transform slot in slots.transform)
        {
            if (slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.property.usable)
            {
                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "arm+leg")
                {
                    text.GetComponent<ChatController>().objectText.text = "누군가의 팔다리";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "bowl")
                {
                    text.GetComponent<ChatController>().objectText.text = "밥그릇";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "ddukbaegi")
                {
                    text.GetComponent<ChatController>().objectText.text = "뚝배기";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "ddukbaegi_finished")
                {
                    text.GetComponent<ChatController>().objectText.text = "육개장";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "doma")
                {
                    text.GetComponent<ChatController>().objectText.text = "도마";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "eyeball")
                {
                    text.GetComponent<ChatController>().objectText.text = "누군가의 눈알";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "flower_item")
                {
                    text.GetComponent<ChatController>().objectText.text = "뼈살이꽃";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "gosari")
                {
                    text.GetComponent<ChatController>().objectText.text = "고사리";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "gukgogi")
                {
                    text.GetComponent<ChatController>().objectText.text = "손질된 고기";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "knife")
                {
                    text.GetComponent<ChatController>().objectText.text = "식칼";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "nongyak")
                {
                    text.GetComponent<ChatController>().objectText.text = "농약";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "one_chopari")
                {
                    text.GetComponent<ChatController>().objectText.text = "초파리";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "potato+sprout")
                {
                    text.GetComponent<ChatController>().objectText.text = "싹이 난 감자";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "recipe_unfolded")
                {
                    text.GetComponent<ChatController>().objectText.text = "쪽지";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "recipe_unfolded")
                {
                    text.GetComponent<ChatController>().objectText.text = "레시피";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "ricebowl")
                {
                    text.GetComponent<ChatController>().objectText.text = "갓 지은 밥";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "seed")
                {
                    text.GetComponent<ChatController>().objectText.text = "씨앗";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "seje")
                {
                    text.GetComponent<ChatController>().objectText.text = "트리오 세제";
                }

                if (slot.GetChild(0).GetComponent<Image>().sprite.name == "ssal")
                {
                    text.GetComponent<ChatController>().objectText.text = "이천쌀";
                }

                slot.GetComponent<Image>().color = new Color(.7f, .78f, .39f, 1);
            }
            else if (slot.gameObject == currentSelectedSlot && slot.GetComponent<Slot>().ItemProperty == Slot.property.displayable) {
                slot.GetComponent<Slot>().DisplayItem();
            }
            else
            {
                slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
        }
    }

    void HideDisplay()
    {
        if (Input.GetMouseButtonDown(0) && UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            //m_Canvas.renderMode = RenderMode.ScreenSpaceCamera;
            itemDisplayer.SetActive(false);
            //for (int i = 0; i < openThings.Length; i++)
            //{
            //    openThings[i].SetActive(true);
            //}

            

            if (currentSelectedSlot.GetComponent<Slot>().ItemProperty == Slot.property.displayable)
            {
                currentSelectedSlot = previousSelectedSlot;
                previousSelectedSlot = currentSelectedSlot;

                
            }
        }
    }
}
