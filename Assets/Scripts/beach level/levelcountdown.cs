using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class levelcountdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] float Remainingtime;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;
    public GameObject spawner7;
    public GameObject spawner8;

    void Update()
    {
        if (Remainingtime > 0)
        { 
            Remainingtime -= Time.deltaTime;
        }

        if (Remainingtime < 90)
        { 
            spawner7.SetActive(true);
            spawner8.SetActive(true);
        }

        if (Remainingtime < 60)
        { 
            spawner1.SetActive(true);
            spawner2.SetActive(true);

        }

        if (Remainingtime < 30)
        { 
            spawner3.SetActive(true);
            spawner4.SetActive(true);
        }
        if (Remainingtime < 15)
        { 
            spawner5.SetActive(true);
            spawner6.SetActive(true);
        }
        if (Remainingtime < 0)
        {
            Remainingtime = 0;
            SceneManager.LoadScene("jungle");
        }
        int minutes = Mathf.FloorToInt(Remainingtime / 60);
        int seconds = Mathf.FloorToInt(Remainingtime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
