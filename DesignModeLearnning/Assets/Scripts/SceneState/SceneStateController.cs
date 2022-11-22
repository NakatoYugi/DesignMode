using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneStateController
{
    private ISceneState mState;
    private AsyncOperation mAo;
    private bool mIsRunStart = false;

    public void SetState(ISceneState state, bool ScneLoad = true)
    {
        if (mState != null)
        {
            mState.StateEnd();
        }
        mState = state;
        if (ScneLoad)
        {
            mAo = SceneManager.LoadSceneAsync(mState.SceneName);
            mIsRunStart = false;
        }
        else
        {
            mState.StateStart();
            mIsRunStart = true;
        }
    }

    public void StateUpdate()
    {
        if (mAo != null && mAo.isDone == false) return;
        if (!mIsRunStart && mAo != null && mAo.isDone == true)
        {
            mIsRunStart = !mIsRunStart;
            mState.StateStart();
        }

        if (mState != null)
        {
            mState.StateUpdate();
        }
    }
}

