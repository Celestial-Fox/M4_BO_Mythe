using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MyButtonHandler : MonoBehaviour
{
    [SerializeField] Button StartButton;

    private void Start()
    {
        StartButton.onClick.AddListener(ClickStartButton);
        
    }

    private void ClickStartButton()
    {
        SceneManager.LoadScene(0);
    }
}
