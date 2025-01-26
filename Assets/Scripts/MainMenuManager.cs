using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    [SerializeField] GameObject mainScreen;
    [SerializeField] GameObject credits;

    private void Start()
    {
        mainScreen.SetActive(true);
        credits.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Credits()
    {
        mainScreen.SetActive(false);
        credits.SetActive(true);
    }

    public void Back()
    {
        mainScreen.SetActive(true);
        credits.SetActive(false);
    }
}
