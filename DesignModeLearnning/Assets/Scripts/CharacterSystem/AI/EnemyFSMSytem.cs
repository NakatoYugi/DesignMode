using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyFSMSystem : FSMSystem<EnemyTransition, EnemyStateID>
{
    public override void PerformTransition(EnemyTransition trans)
    {
        if (trans == EnemyTransition.NullTansition)
        {
            Debug.LogError("Can't Perform NUll Transition!");
            return;
        }
        EnemyStateID nextStateID = mCurrentState.GetState(trans);
        if (nextStateID == EnemyStateID.NullState)
        {
            Debug.LogError("Can't Trans To Null State");
            return;
        }
        foreach (var item in mStates)
        {
            if (item.StateID == nextStateID)
            {
                mCurrentState.DoBeforEntering();
                mCurrentState = item;
                mCurrentState.DoAfterLeaving();
                return;
            }
        }
    }
}

