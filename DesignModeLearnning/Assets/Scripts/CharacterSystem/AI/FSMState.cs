using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public enum SoldierTransition
{
    NullTansition = 0,
    SeeEnemy,
    NoEnmey,
    CanAttack
}
public enum SoldierStateID
{
    NullState,
    Idle,
    Chase,
    Attack
}
public enum EnemyTransition
{
    NullTansition = 0,
    CanAttack,
    LostSoldier
}
public enum EnemyStateID
{
    NullState,
    Chase,
    Attack
}


public abstract class FSMState<T_Transition, T_State>
    where T_Transition : Enum
    where T_State : Enum
{
    protected Dictionary<T_Transition, T_State> mTranToStateDic = new Dictionary<T_Transition, T_State>();
    protected T_State mStateID;
    protected ICharacter mCharacter;
    protected FSMSystem<T_Transition, T_State> mFSM;

    public FSMState(FSMSystem<T_Transition, T_State> fsm, ICharacter character)
    {
        this.mFSM = fsm;
        this.mCharacter = character;
    }

    public T_State StateID { get { return mStateID; } }

    public T_State GetState(T_Transition trans)
    {
        if (!mTranToStateDic.ContainsKey(trans))
        {
            return default(T_State);
        }
        return mTranToStateDic[trans];
    }

    public void AddTransition(T_Transition trans, T_State id)
    {
        if (mTranToStateDic.ContainsKey(trans))
        {
            Debug.LogError("Transition:"+trans+"Had Added!");
            return;
        }
        mTranToStateDic.Add(trans,id);
    }

    public void DeleteTransition(T_Transition trans)
    {
        if (mTranToStateDic.ContainsKey(trans) == false)
        {
            Debug.LogError("Not Contains Transition:"+trans);
            return;
        }
        mTranToStateDic.Remove(trans);
    }

    public virtual void DoBeforEntering() { }
    public virtual void DoAfterLeaving() { }
    public abstract void Reason(List<ICharacter> targets);
    public abstract void Act(List<ICharacter> targets);

}

