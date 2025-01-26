using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SodaCan : MonoBehaviour
{

    int playersColliding = 0;

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Collision");

        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Player 2")
        {
            playersColliding++;

            // Check if both players are now colliding
            if (playersColliding == 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "Player 2")
        {
            playersColliding--;
        }
    }
}
