using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] inventory = new GameObject[2];
    SpriteRenderer sprite;

    public void AddItem(GameObject gameObject)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = gameObject;
                break;

            }
        }

    }



}
