using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossShortcut : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene(12) ;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(17);
        }
    }
}
