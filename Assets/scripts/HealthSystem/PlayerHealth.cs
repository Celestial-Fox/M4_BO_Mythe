using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;

    [SerializeField] private float invincibilityDuration = 1.0f;
    private bool isInvincible = false;

    private Collider2D playerCollider;

    void Start()
    {
        health = maxHealth;
        playerCollider = GetComponent<Collider2D>(); // Zorg dat dit script op hetzelfde object zit als de Collider2D
    }

    public void TakeDamage(int amount)
    {
        if (isInvincible) return;

        health -= amount;
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            return;
        }

        StartCoroutine(InvincibilityCoroutine());
    }

    public void Addhealth(int amount)
    {
        health += amount;
        if (health > maxHealth) health = maxHealth;
    }

    private IEnumerator InvincibilityCoroutine()
    {
        isInvincible = true;

        // Zet collider uit
        if (playerCollider != null)
        {
            playerCollider.enabled = false;
        }

        yield return new WaitForSeconds(invincibilityDuration);

        // Zet collider weer aan
        if (playerCollider != null)
        {
            playerCollider.enabled = true;
        }

        isInvincible = false;
    }
}
