using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class FSMSystem<T_Transition,T_State>
    where T_Transition:Enum
    where T_State:Enum
{
    protected List<FSMState<T_Transition, T_State>> mStates = new List<FSMState<T_Transition, T_State>>();
    protected HashSet<FSMState<T_Transition, T_State>> mState_Set = new HashSet<FSMState<T_Transition, T_State>>();
    protected FSMState<T_Transition, T_State> mCurrentState;

    public FSMState<T_Transition, T_State> CurrentState { get { return mCurrentState; } }

    public void AddState(FSMState<T_Transition,T_State> state)
    {
        if (state == null)
        {
            Debug.LogError("Can't Add Null State!");
            return;
        }
        if (mStates.Count <= 0)
        {
            mStates.Add(state);
            mState_Set.Add(state);
            mCurrentState = state;
            mCurrentState.DoBeforEntering();
            return;
        }
        else
        {
            foreach (var s in mStates)
            {
                if (mState_Set.Contains(state))
                {
                    Debug.LogError("State:"+state.StateID + " had added!");
                    return;
                }
            }
        }
        mStates.Add(state);
        mState_Set.Add(state);
    }

    public void DeleteState(FSMState<T_Transition, T_State> state)
    {
        if (!mState_Set.Contains(state))
        {
            Debug.LogError("Can't Delete State:"+state.StateID);
            return;
        }
        mStates.Remove(state);
        mState_Set.Remove(state);
    }

    public abstract void PerformTransition(T_Transition trans);
}

