using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public Sprite emptyDroplet;
    public Sprite fullDroplet;
    public Image[] droplets;

    public PlayerHealth playerHealth;

    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;

        int displayDropletCount = droplets.Length;
        float healthPerDroplet = maxHealth / displayDropletCount;

        for (int i = 0; i < displayDropletCount; i++)
        {
            float threshold = (i + 1) * healthPerDroplet;

            if (health >= threshold)
            {
                droplets[i].sprite = fullDroplet;
            }
            else
            {
                droplets[i].sprite = emptyDroplet;
            }

            droplets[i].enabled = true;
        }
    }
}