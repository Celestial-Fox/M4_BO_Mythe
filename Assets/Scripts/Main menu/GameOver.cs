using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MyButtonHandler : MonoBehaviour
{
    public void ClickStartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ClickExitButton()
    {
        Application.Quit();
    }
}
