
using TopDown.Movement;
using UnityEngine;

public class CharacterAnimationManager : MonoBehaviour
{
    [SerializeField] private GameObject frontRig;
    [SerializeField] private GameObject sideRigLeft;
    [SerializeField] private GameObject sideRigRight;
    [SerializeField] private GameObject backRig;

    private Animator currentAnimator;

    void Start()
    {
        SwitchTo(frontRig);
    }

    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (input.y > 0)
        {
            SwitchTo(backRig);
        }
        else if (input.y < 0)
        {
            SwitchTo(frontRig);
        }
        else if (input.x < 0)
        {
            SwitchTo(sideRigLeft);
        }
        else if (input.x > 0)
        {
            SwitchTo(sideRigRight);
        }

        // Animator bijwerken
        if (currentAnimator != null)
        {
            float speed = input.magnitude;
            currentAnimator.SetFloat("Speed", speed);
            currentAnimator.SetBool("IsMoving", speed > 0);
        }
    }

    void SwitchTo(GameObject targetRig)
    {
        // Alle rigs uitschakelen
        frontRig.SetActive(false);
        sideRigLeft.SetActive(false);
        backRig.SetActive(false);
        sideRigRight.SetActive(false);

        // Nieuwe rig activeren
        targetRig.SetActive(true);
        currentAnimator = targetRig.GetComponent<Animator>();
    }
}

