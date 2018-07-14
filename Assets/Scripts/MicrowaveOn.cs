using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveOn : MonoBehaviour {
    public GameObject Microwave;
    public SpriteRenderer onImage;


    private void OnValidate()
    {
        onImage = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        onImage.enabled = false;
    }

    private void OnMouseOver()
    {
        
        if(Input.GetMouseButtonDown(0) && onImage.enabled == false)
        {
            onImage.enabled = true;  
        } else if (Input.GetMouseButtonDown(0) && onImage.enabled == true)
        {
            onImage.enabled = false;
        }
    }


}
