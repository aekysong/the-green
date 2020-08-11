using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController : MonoBehaviour {

    public Text objectText;
    private SpriteRenderer currentDisplay;

    // Use this for initialization
    void Start () {
        currentDisplay = GameObject.Find("displayImage").GetComponent<SpriteRenderer>();
        objectText.text = "";

        //Debug.Log(currentDisplay.sprite.name);
        
	}
	
	// Update is called once per frame
	void Update () {
        if (currentDisplay.sprite.name == "kitchen_wall3")
        {
            objectText.color = Color.white;
        } else
        {
            objectText.color = Color.black;
        }
    }
}
