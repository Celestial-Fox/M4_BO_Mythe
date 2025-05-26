
using UnityEngine;

namespace TopDown.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        private Rigidbody2D body;
        private Vector2 movement;
        private Animator animator;

        //Previously used code
        //protected Vector3 currentInput;
        //public Vector3 CurrentInput => currentInput;

        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }

        private void FixedUpdate()
        {
            //body.velocity = movementSpeed * currentInput *  Time.deltaTime;
            body.MovePosition(body.position + movement * movementSpeed * Time.deltaTime);
        }
    }
}
