
using UnityEngine;

public abstract class IWepon
{
    protected int mAtk;
    protected float mAttackRange;
    protected int mAtkPlusValue;

    protected GameObject mGameObject;
    protected ICharacter mOwner;
    protected ParticleSystem mParticle;
    protected LineRenderer mLine;
    protected Light mLight;
    protected AudioSource mAudio;

    public abstract void Fire(Vector3 targetPosition);
}

