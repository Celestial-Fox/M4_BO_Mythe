using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject Creditsmenu;
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

    public void Credits()
    {
        camera1.SetActive(false);
        camera3.SetActive(true);
        MainMenu.SetActive(false);
        Creditsmenu.SetActive(true);
    }
}
