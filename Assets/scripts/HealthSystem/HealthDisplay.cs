using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public Sprite emptyDroplet;
    public Sprite halfDroplet;
    public Sprite fullDroplet;
    public Image[] droplets;

    public PlayerHealth playerHealth;

    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;

        int dropletCount = droplets.Length;
        float healthPerDroplet = maxHealth / dropletCount;

        for (int i = 0; i < dropletCount; i++)
        {
            float lowerBound = i * healthPerDroplet;
            float upperBound = (i + 1) * healthPerDroplet;

            if (health >= upperBound)
            {
                droplets[i].sprite = fullDroplet;
            }
            else if (health > lowerBound)
            {
                droplets[i].sprite = halfDroplet;
            }
            else
            {
                droplets[i].sprite = emptyDroplet;
            }

            droplets[i].enabled = true;
        }
    }
}