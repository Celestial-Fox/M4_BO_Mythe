
using UnityEngine;

namespace TopDown.CameraControl
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]private Transform playerTransform;
        private float zPosition = -10;
        [SerializeField] private float displacementMultiplier = 0.15f;

        private void Update()
        {
            //Calculate mouse position in world coordinates then calculates distance between player and mouse to determine displacement
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 cameraDisplacement = (mousePosition - playerTransform.position) * displacementMultiplier;

            //Determine final camera position
            Vector3 finalCameraPosition = playerTransform.position + cameraDisplacement;
            finalCameraPosition.z = zPosition;
            transform.position = finalCameraPosition;
        }
    }
}
