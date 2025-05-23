using System.Collections;
using System.Collections.Generic;
using TopDown.Movement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health;
    public float maxHealth = 100;

    public SpriteRenderer player;
    public MovementPlayer PlayerMovement;




    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
        {
            player.enabled = false;
            PlayerMovement.enabled = false;
        }

    }
}