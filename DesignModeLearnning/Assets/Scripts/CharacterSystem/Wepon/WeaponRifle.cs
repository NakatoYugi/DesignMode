
using UnityEngine;

public class WeaponRifle : IWepon
{
    protected override void DemonstrateBulletEffect(Vector3 targetPosition)
    {
        SetBulletEffect(0.8f, targetPosition);
    }

    protected override void PlaySound()
    {
        DoPlaySound("RifleShot");
    }
}

