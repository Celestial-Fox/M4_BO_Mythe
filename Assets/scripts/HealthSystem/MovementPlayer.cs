using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    
    [SerializeField] private float movementSpeed = 2f;

    private Rigidbody2D rb;

    private Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //Debug.Log($"horizontal: {Input.GetAxis("Horizontal")}, vertical: {Input.GetAxis("Vertical")}");
        rb.velocity = movementDirection * movementSpeed;
    }
}
