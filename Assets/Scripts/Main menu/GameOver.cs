using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    private void Retry()
    {
        //SceneManager.LoadScene("Steale's Scene");
        Debug.Log("Button was clicked!");
    }

    
}
