using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Rigidbody2D rb;
    [SerializeField] float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2 (direction.x, direction.y).normalized * speed;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
