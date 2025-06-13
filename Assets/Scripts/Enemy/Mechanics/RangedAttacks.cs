using UnityEngine;

public class RangedAttacks : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;

    private float timer;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2) 
        {
            timer = 0;
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
