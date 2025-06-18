
using UnityEngine;

namespace TopDown.CameraControl
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]private Transform playerTransform;
        private float zPosition = -10;
        [SerializeField] private float displacementMultiplier = 0.15f;
        private Bounds camerabounds;
        private Vector3 targerposition;
        private Camera maincamera;

        private void Awake() => maincamera = Camera.main;

        private void Start()
        {
            var height = maincamera.orthographicSize;
            var width = height * maincamera.aspect;

            var Minx = globals.worldbounds.min.x + width;
            var Maxx = globals.worldbounds.extents.x - width;

            var Miny = globals.worldbounds.min.y + height;
            var Maxy = globals.worldbounds.extents.y - height;

            camerabounds = new Bounds();
            camerabounds.SetMinMax(
                new Vector3(Minx, Miny, 0.0f),
                new Vector3(Maxx, Maxy, 0.0f)
                );
        }

        private Vector3 ClampToCameraBounds(Vector3 position)
        {
            return new Vector3(
                Mathf.Clamp(position.x, camerabounds.min.x, camerabounds.max.x),
                Mathf.Clamp(position.y, camerabounds.min.y, camerabounds.max.y),
                zPosition
            );
        }




        private void Update()
        {
            // 1. Haal muispositie in wereldruimte
            Vector3 mouseWorldPosition = maincamera.ScreenToWorldPoint(Input.mousePosition);

            // 2. Bereken de richting van de muis t.o.v. de speler
            Vector3 directionToMouse = mouseWorldPosition - playerTransform.position;

            // 3. Beperk Z tot 0 zodat de camera niet in 3D-space gaat zweven
            directionToMouse.z = 0;

            // 4. Voeg de offset toe aan de spelerpositie
            Vector3 targetPosition = playerTransform.position + directionToMouse * displacementMultiplier;

            // 5. Fixeer de Z-positie van de camera
            targetPosition.z = zPosition;

            // 6. Clamp camera binnen grenzen
            transform.position = ClampToCameraBounds(targetPosition);
        }
    }
}
