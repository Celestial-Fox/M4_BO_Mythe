using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countdownjungle : MonoBehaviour
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
            Spawner.startTimeBtwSpawn = 4;
        }

        if (Remainingtime < 60)
        {
            Spawner.startTimeBtwSpawn = 3;
        }

        if (Remainingtime < 45)
        {
            Spawner.startTimeBtwSpawn = 2;
        }

        if (Remainingtime < 30)
        {
            Spawner.startTimeBtwSpawn = 1;
        }

        if (Remainingtime < 0)
        {
            Remainingtime = 0;
            SceneManager.LoadScene(7);
        }
        int minutes = Mathf.FloorToInt(Remainingtime / 60);
        int seconds = Mathf.FloorToInt(Remainingtime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}

