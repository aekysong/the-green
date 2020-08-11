﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInside : MonoBehaviour, IInteractable {

    public string SpriteName;

    public void Interact(DisplayImage currentDisplay)
    {
        currentDisplay.GetComponent<SpriteRenderer>().sprite =
            Resources.Load<Sprite>("Sprites/" + SpriteName);
    }
}
