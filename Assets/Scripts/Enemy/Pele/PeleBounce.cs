using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PeleBounce : MonoBehaviour
{
    [SerializeField] private float pushForce = 10f;
    [SerializeField] private GameObject rig;
    public float health = 200;

    public AnimationClip myAnimationClip;

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            transform.rotation = Quaternion.identity;
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // Calculating the direction away from player
                Vector2 pushDirection = (transform.position - collision.transform.position).normalized;

                // Apply force
                rb.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
                yield return new WaitForSeconds(.5f);
                rb.AddForce(-pushDirection * pushForce, ForceMode2D.Impulse);
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            health -= 20;
            
        }
    }
    private void Update()
    {
            
    }
}
