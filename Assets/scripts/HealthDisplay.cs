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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;

        for (int i = 0; i < maxHealth; i++)
        {
            if(i < health)
            {
                droplets[i].sprite = fullDroplet;
            }
            else
            {
                droplets[i].sprite = emptyDroplet;
            }

            if (i < maxHealth)
            {
                droplets[i].enabled = true;
            }
            else
            {
                droplets[i].enabled = false;
            }
        }
    }
}
