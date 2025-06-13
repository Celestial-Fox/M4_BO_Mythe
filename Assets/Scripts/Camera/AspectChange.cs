using UnityEngine;

public class AspectChange : MonoBehaviour
{
    [SerializeField] private float width;
    [SerializeField] private float height;
    void Start()
    {
        Camera.main.aspect = width / height;
    }
}
