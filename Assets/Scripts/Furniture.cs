using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour {

    public Sprite currentSprite;
    public Sprite nextSprite;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = currentSprite;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 clickPos = new Vector2(worldPos.x, worldPos.y);
            Ray2D ray = new Ray2D(clickPos, Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.name == "display_cupboard_with_door")
                {
                    Debug.Log(hit.collider.name);

                    if (spriteRenderer.sprite == currentSprite)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite;
                    }
                    else if (spriteRenderer.sprite == nextSprite)
                    {
                        gameObject.GetComponent<SpriteRenderer>().sprite = currentSprite;
                    }
                }
            }
        }
    }
}
