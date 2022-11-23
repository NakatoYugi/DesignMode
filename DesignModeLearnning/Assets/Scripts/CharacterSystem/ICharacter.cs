

using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter
{

    protected ICharacterAttribute mAttribute;
    protected GameObject mGameObject;
    protected NavMeshAgent mNavMeshAgent;
    protected AudioSource mAudio;

    protected IWepon mWepon;

    public IWepon weapon { set { mWepon = value; } }

    public void Attack(Vector3 targetPosition)
    {
        mWepon.Fire(targetPosition);
    }
}

