using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conv_Script : MonoBehaviour, IInteractable {

    public Text conv_text;
    private int count;

    // Use this for initialization
    void Start () {
        conv_text.text = "";
        count = 0;
    }

    public void Interact(DisplayImage currentDisplay)
    {
        if (count == 0)
        {
            conv_text.text = "밥 줘!";
            count += 1;
        }

        if (count == 1)
        {
            conv_text.text = "나 4년제 대학 나온 사람이야!";
            count += 1;
        }

        if (count == 2)
        {
            conv_text.text = "난 엄마가 만들어주는 육개장이 그렇게 맛있더라";
            count = 0;
        }
        
    }
}
