
using TopDown.Movement;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class legy : MonoBehaviour
{
    [SerializeField] private movement playerMovement;
    private Animator legsAnimator;

    private void Awake()
    {
        legsAnimator = GetComponent<Animator> ();
    }

    private void Update()
    {
        legsAnimator.SetBool("moving", playerMovement.CurrentInput != Vector3.zero);
    }
}
