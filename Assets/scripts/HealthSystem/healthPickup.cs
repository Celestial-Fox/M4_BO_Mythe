using System.Collections;
using System.Collections.Generic;
using TopDown.Movement;
using UnityEngine;

public class healthPickup : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject HealthPickup;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (playerHealth == null)
            {
                playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            }
            playerHealth.Addhealth(20);
        }

        if (collision.gameObject.tag == "player")
        {
            Destroy(HealthPickup);
        }
    }
}