using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gooncamera : MonoBehaviour
{
    void Update()
    {
        // Generate a new random color every frame
        Color randomColor = new Color(
            Random.Range(0f, 1f), // Red
            Random.Range(0f, 1f), // Green
            Random.Range(0f, 1f)  // Blue
        );

        // Set the camera's background color
        Camera camera = GetComponent<Camera>();
        camera.backgroundColor = randomColor;
    }
}
