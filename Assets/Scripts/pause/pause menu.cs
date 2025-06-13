using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenuUI.activeSelf)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        player.SetActive(false); 
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        player.SetActive(true);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
}