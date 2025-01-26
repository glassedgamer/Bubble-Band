using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public GameObject objectOne;
    public GameObject objectTwo;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectOne.SetActive(true);
            objectTwo.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        objectOne.SetActive(false);
        objectTwo.SetActive(false);
    }
}
