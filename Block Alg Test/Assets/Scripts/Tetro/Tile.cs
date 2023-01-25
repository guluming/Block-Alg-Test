using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null) {

        }
    }

    public Color color
    {
        set {
            spriteRenderer.color = value;
        }

        get {
            return spriteRenderer.color;
        }
    }

    public int sortingOrder
    {
        set {
            spriteRenderer.sortingOrder = value;
        }

        get {
            return spriteRenderer.sortingOrder;
        }
    }
}
