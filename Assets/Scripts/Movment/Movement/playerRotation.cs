
using UnityEngine;
using UnityEngine.InputSystem;

namespace TopDown.Movement
{


    public class playerRotation : rotater
    {
        [Header("Torso & legs")]
        [SerializeField] private Transform torso;
        [SerializeField] private Transform legs;

        //[Header("movement Refrence")]
        //[SerializeField] private Movement movementPlayer;

        //Determine mouse position and look that way
        private void OnLook(InputValue value)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
            lookAt(torso, mousePosition);
        }

        /*private void Update()
        {
            //Rotate legs to face movement direction
            Vector3 legsLookPoint = transform.position + new Vector3(movementPlayer.CurrentInput.x, movementPlayer.CurrentInput.y);
            lookAt(legs, legsLookPoint);
        }*/
    }
}
