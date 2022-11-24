
using UnityEngine;

public class WeaponLaser : IWepon
{
    protected override void DemonstrateBulletEffect(Vector3 targetPosition)
    {
        SetBulletEffect(0.75f, targetPosition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("LaserShot");
    }
}

