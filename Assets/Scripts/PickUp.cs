using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public GameObject gameObject;
    Inventory inventory;
    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            inventory.AddItem(gameObject);
        }
    }
}
