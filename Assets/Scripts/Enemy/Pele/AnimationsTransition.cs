using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationsTransition : MonoBehaviour
{

    public PeleBounce peleBounce;
    [SerializeField] private float health;
    

    [SerializeField] private GameObject entrance;
    [SerializeField] private GameObject idle;
    [SerializeField] private GameObject exit;
    [SerializeField] private GameObject lavaRing;
    [SerializeField] private GameObject gun;

    public AnimationClip myAnimationClip;
    private float startIdle = 1.75f;
    private float startIdleTimer;

    private float destroyTimer = 2.5f;
    private float BeginDestroy;
    private bool deathTime;
    void Start()
    {
        entrance.SetActive(true);
        idle.SetActive(false);
        exit.SetActive(false);
        lavaRing.SetActive(false);

        if (myAnimationClip != null)
        {
            float animationLength = myAnimationClip.length;
            Debug.Log("Animation Length: " + animationLength);
        }

        health = peleBounce.health;
    }

    void Update()
    {
        health = peleBounce.health;

        startIdleTimer += Time.deltaTime;
        if (startIdleTimer > startIdle && startIdleTimer < 2)
        {
            entrance.SetActive(false);
            idle.SetActive(true);
            exit.SetActive(false);
            lavaRing.SetActive(true);
        }

        if (health <= 0)
        {
            deathTime = true;
            Debug.Log("!!!");
            entrance.SetActive(false);
            idle.SetActive(false);
            exit.SetActive(true);
            lavaRing.SetActive(false);
            gun.SetActive(false);
        }

        if (deathTime)
        {
            BeginDestroy += Time.deltaTime;
        }

        if (BeginDestroy >= destroyTimer)
        {
            Debug.Log("Ded");
            Destroy(gameObject);
            lavaRing.SetActive(true);
            SceneManager.LoadScene(17);
        }
    }


}
