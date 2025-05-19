using UnityEngine;

namespace TopDown.Shooting
{
    public class gunController : MonoBehaviour
    {
        [Header("Cooldown")]
        [SerializeField] private float cooldown = 0.25f;
        private float cooldownTimer;

        [Header("Refrences")]
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firepoint;
        [SerializeField] private Animator muzzleFlashAnimator;

        //shoot point

        private void Update()
        {
            cooldownTimer += Time.deltaTime;
        }

        private void Shoot()
        {
            if (cooldownTimer > cooldown)
            {
                GameObject bullet = Instantiate(bulletPrefab);
                muzzleFlashAnimator.SetTrigger("Shoot");
                Debug.Log("Shot!");
                cooldownTimer = 0;
            }
        }

        //#region Input
        private void OnShoot()
        {
            Shoot();
        }
        //#endregion
    }
}
