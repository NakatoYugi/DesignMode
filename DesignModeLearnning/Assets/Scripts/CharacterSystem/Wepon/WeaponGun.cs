
using UnityEngine;

public class WeaponGun : IWepon
{
    protected override void DemonstrateBulletEffect(Vector3 targetPosition)
    {
        SetBulletEffect(0.1f, targetPosition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("GunShot");
    }
}

