using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public void StartGame()
    {
        SceneManager.LoadScene("Steale's Scene");
    }

    public void Gooner()
    { 
     SceneManager.LoadScene("GoonerScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
