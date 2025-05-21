
using TopDown.Movement;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class walk : MonoBehaviour
{
    [SerializeField] private movement playerMovement;
    private Animator playerChaeachter_spriteAnimator;

    private void Awake()
    {
        playerChaeachter_spriteAnimator = GetComponent<Animator> ();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            playerChaeachter_spriteAnimator.SetBool("movingS", playerMovement.CurrentInput != Vector3.zero);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerChaeachter_spriteAnimator.SetBool("movingE", playerMovement.CurrentInput != Vector3.zero);
        }
    }
}
