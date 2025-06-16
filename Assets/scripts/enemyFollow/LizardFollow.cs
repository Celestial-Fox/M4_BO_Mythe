using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardFollow : MonoBehaviour
{
    public GameObject player;
    public float speed = 2f;
    public float distanceBetween = 10f;

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player not assigned in LizardFollow script.");
            return;
        }

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance < distanceBetween)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}