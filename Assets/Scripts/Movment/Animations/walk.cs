
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
        playerChaeachter_spriteAnimator.SetBool("moving", playerMovement.CurrentInput != Vector3.zero);
    }
}
