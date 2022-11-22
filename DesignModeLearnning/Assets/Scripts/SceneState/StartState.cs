

using UnityEngine;
using UnityEngine.UI;

public class StartState : ISceneState
{
    private Image mLogo;
    private float mSmoothingSpeed = 1f;
    private float WaitTime = 2f;
    private float LastEnterTime = 0f;
    public StartState(SceneStateController controller) : base("StartScene", controller)
    {

    }

    public override void StateStart()
    {
        if (!mLogo) mLogo = GameObject.Find("Logo").GetComponent<Image>();
        mLogo.color = Color.black;
        LastEnterTime = Time.time;
    }

    public override void StateUpdate()
    {
        if (Time.time - LastEnterTime >= WaitTime)
        {
            mController.SetState(new MainMenuState(mController));
        }

        mLogo.color = Color.Lerp(mLogo.color, Color.white, mSmoothingSpeed * Time.deltaTime);
    }
}

