using UnityEngine;

public class RangedAttacks : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    public PeleBounce peleBounce;
    [SerializeField] private float health;

    private float cooldown = 2;
    private float shootTime;
    [Space]
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;
    public GameObject enemy10;
    public GameObject enemy11;
    public GameObject enemy12;
    public GameObject enemy13;
    public GameObject enemy14;
    public GameObject enemy15;
    public GameObject enemy16;
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

        if (health <= 180 && enemy1 != null)
            enemy1.SetActive(true);

        if (health <= 160 && enemy2 != null)
            enemy2.SetActive(true);

        if (health <= 140 && enemy3 != null)
            enemy3.SetActive(true);

        if (health <= 120)
        {
            if (enemy4 != null) enemy4.SetActive(true);
            if (enemy5 != null) enemy5.SetActive(true);
        }

        if (health <= 100)
        {
            if (enemy6 != null) enemy6.SetActive(true);
            if (enemy7 != null) enemy7.SetActive(true);
            if (enemy8 != null) enemy8.SetActive(true);
        }

        if (health <= 80)
        {
            if (enemy9 != null) enemy9.SetActive(true);
            if (enemy10 != null) enemy10.SetActive(true);
        }

        if (health <= 60)
        {
            if (enemy11 != null) enemy11.SetActive(true);
            if (enemy12 != null) enemy12.SetActive(true);
        }

        if (health <= 40 && enemy13 != null)
            enemy13.SetActive(true);

        if (health <= 20)
        {
            if (enemy14 != null) enemy14.SetActive(true);
            if (enemy15 != null) enemy15.SetActive(true);
            if (enemy16 != null) enemy16.SetActive(true);
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
