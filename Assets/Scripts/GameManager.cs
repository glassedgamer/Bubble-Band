using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            print("Quitting now idiots");
            Application.Quit();
        }
    }
}