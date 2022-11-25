using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SoliderFSMSystem : FSMSystem<SoldierTransition, SoldierStateID>
{
    //TODO:Test
    public void Update()
    {
        if (mCurrentState != null)
        {
            mCurrentState.Act(null);
            mCurrentState.Reason(null);
        }
    }

    public override void PerformTransition(SoldierTransition trans)
    {
        Debug.Log("Perform Trans!");
        if (trans == SoldierTransition.NullTansition)
        {
            Debug.LogError("Can't Perform NUll Transition!");
            return;
        }
        SoldierStateID nextStateID = mCurrentState.GetState(trans);
        if (nextStateID == SoldierStateID.NullState)
        {
            Debug.LogError("Can't Trans To Null State");
            return;
        }
        Debug.Log("nextState:"+nextStateID.ToString());
        foreach (var item in mStates)
        {
            if (item.StateID == nextStateID)
            {
                mCurrentState.DoAfterLeaving();
                mCurrentState = item;
                mCurrentState.DoBeforEntering();
                return;
            }
        }
    }
}

