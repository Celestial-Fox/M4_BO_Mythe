using UnityEngine;

public class RangedAttacks : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    public PeleBounce peleBounce;
    [SerializeField] private float health;

    private float cooldown = 2;
    private float shootTime;
    void Start()
    {
        
    }

    void Update()
    {
        health = peleBounce.health;

        shootTime += Time.deltaTime;

        if (shootTime > cooldown) 
        {
            shootTime = 0;
            shoot();
        }

        if (health == 100)
        {
            cooldown = 1;
        }

        if (health <= 50)
        {
            cooldown = 0.5f;
        }
    }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
