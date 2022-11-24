
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
    protected float mEffectDisplayTime = 1f;
    private float LastFireTime = 0f;
    protected void SetEffectDisplayTime(float time) { mEffectDisplayTime = time; }

    //模板方法
    public void Fire(Vector3 targetPosition)
    {
        LastFireTime = Time.time;
        DemonstateMuzzleEffect();

        DemonstrateBulletEffect(targetPosition);

        PlaySound();
    }

    protected virtual void DemonstateMuzzleEffect()
    {
        //显示枪口特效
        mParticle.Stop();
        mParticle.Play();
        mLight.enabled = true;
    }

    public void Update()
    {
        if (Time.time - LastFireTime >= mEffectDisplayTime)
        {
            DisableEffet();
        }
    }

    protected virtual void SetBulletEffect(float wiedth, Vector3 targetPosition) 
    {
        //显示子弹轨迹特效
        mLine.enabled = true;
        mLine.startWidth = wiedth;
        mLine.endWidth = wiedth;
        mLine.SetPositions(new Vector3[] { mGameObject.transform.position, targetPosition });
    }
    protected abstract void DemonstrateBulletEffect(Vector3 targetPosition);
    

    protected virtual void DoPlaySound(string Clipname) 
    {
        string mClipName = Clipname;
        //播放声音
        AudioClip clip = null; //TODO:
        mAudio.clip = clip;
        mAudio.Play();
    }

    protected abstract void PlaySound();

    private void DisableEffet()
    {
        mLight.enabled = false;
        mLine.enabled = false;
    }
}

