using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Door;


    public void OnTriggerEnter2D(Collider2D other) 
    {  
        if (other.CompareTag("Player")) 
        {
            Door.SetActive(false);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Door.SetActive(true);
    }
}
