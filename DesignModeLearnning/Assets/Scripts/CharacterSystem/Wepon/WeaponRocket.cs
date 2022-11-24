
using UnityEngine;

public class WeaponRocket : IWepon
{
    protected override void DemonstrateBulletEffect(Vector3 targetPosition)
    {
        SetBulletEffect(0.9f, targetPosition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("RocketShot");
    }
}

