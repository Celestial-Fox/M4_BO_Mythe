using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class loadingSceneManagerthree : MonoBehaviour
{
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            SceneManager.LoadScene(3);
        }
    }
}
