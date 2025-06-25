using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countdownjungle : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] float Remainingtime;

    void Update()
    {
        if (Remainingtime > 0)
        {
            Remainingtime -= Time.deltaTime;
        }

        if (Remainingtime < 120)
        {
            Spawner.startTimeBtwSpawn = 3;
        }

        if (Remainingtime < 90)
        {
            Spawner.startTimeBtwSpawn = 2;
        }

        if (Remainingtime < 60)
        {
            Spawner.startTimeBtwSpawn = 1;
        }

        if (Remainingtime < 45)
        {
            Spawner.startTimeBtwSpawn = 0.5f;
        }

        if (Remainingtime < 30)
        {
            Spawner.startTimeBtwSpawn = 0.25f;
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

