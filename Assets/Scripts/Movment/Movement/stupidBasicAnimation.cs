using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("LOL!!");
            animator.SetTrigger("Down");
        }
    }
}
