using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverOn : MonoBehaviour {
    public SpriteRenderer closedImage;
    private void OnValidate()
    {
        closedImage = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        closedImage.enabled = false;
    }

    private void OnMouseExit()
    {
        closedImage.enabled = true;
    }
}
