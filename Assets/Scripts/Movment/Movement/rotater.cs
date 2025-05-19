
using UnityEngine;

namespace TopDown.Movement
{
    public class rotater : MonoBehaviour
    {
        protected void lookAt(Transform rotatedTransform, Vector3 target)
        {
            //Calculate angle between transform and target
            float lookAngle = angleBetweenTwoPoints(transform.position, target) - 90;

            //Assign the target rotation on the z axis to the received tranform
            rotatedTransform.eulerAngles = new Vector3(0, 0, lookAngle);
        }
        private float angleBetweenTwoPoints(Vector3 a, Vector3 b)
        {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }
    }
}
