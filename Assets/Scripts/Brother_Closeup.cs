using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brother_Closeup : MonoBehaviour, IInteractable {

    public Animator animator;
    public Text conv_text;
    private int count;

    private void Start()
    {
        conv_text.text = "";
        count = 0;

    }

    

    public void Interact(DisplayImage currentDisplay)
    {
        if (count == 0)
        {
            animator.Play("Conv_Conv", -1, 0f);
            //Debug.Log(count);
            conv_text.text = "밥 줘!";
            count += 1;
        }

        else if (count == 1)
        {
            animator.Play("Conv_Conv", -1, 0f);
            //Debug.Log(count);
            conv_text.text = "나 4년제 대학 나온 사람이야!";
            count += 1;
        }

        else if (count == 2)
        {
            animator.Play("Conv_Conv", -1, 0f);
            //Debug.Log(count);
            conv_text.text = "난 엄마가 만들어주는 육개장이\n 그렇게 맛있더라";
            count = 0;
        }
    }
}
