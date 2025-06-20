using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsTransition : MonoBehaviour
{

    [SerializeField] private GameObject entrance;
    [SerializeField] private GameObject idle;
    [SerializeField] private GameObject exit;

    public AnimationClip myAnimationClip;
    private float startIdle = 1.75f;
    private float startIdleTimer;
    void Start()
    {
        entrance.SetActive(true);
        idle.SetActive(false);
        exit.SetActive(false);

        if (myAnimationClip != null)
        {
            float animationLength = myAnimationClip.length;
            Debug.Log("Animation Length: " + animationLength);
        }

        
}

    void Update()
    {
        startIdleTimer += Time.deltaTime;
        if (startIdleTimer > startIdle)
        {
            entrance.SetActive(false);
            idle.SetActive(true);
            exit.SetActive(false);
        }
    }
}
