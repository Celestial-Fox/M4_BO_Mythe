using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDown.Movement;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;

    [SerializeField] private GameObject player;
    //[SerializeField] private MovementPlayer PlayerMovement;

    
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
<<<<<<< HEAD
    public void Addhealth(int amount)
    {
        health += amount;
    }
=======

>>>>>>> Steale
}
