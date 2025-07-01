using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace TopDown.Shooting
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile : MonoBehaviour
    {
        [Header("Movement Stats")]
        [SerializeField] private float speed;
        [SerializeField] private float lifetime;
        private Rigidbody2D body;
        private float lifeTimer;

        [SerializeField] GameObject pickUp;
        [SerializeField] Transform bulletPos;

        private int randomNumber;
        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
        }

        public void ShootBullet(Transform shootPoint)
        {
            lifeTimer = 0;
            body.velocity = Vector2.zero;
            transform.position = shootPoint.position;
            transform.rotation = shootPoint.rotation;
            gameObject.SetActive(true);
            body.AddForce(-transform.up * speed, ForceMode2D.Impulse);
        }

        private void Update()
        {
            lifeTimer += Time.deltaTime;
            if (lifeTimer >= lifetime)
            {
                gameObject.SetActive(false);
                
            }
            
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
            if (collision.gameObject.CompareTag("Enemy"))
            {
                randomNumber = Random.Range(1,10);
                if (randomNumber <= 2)
                {
                    Instantiate(pickUp, bulletPos.position, Quaternion.identity);
                }
            }
        }


    }
}
