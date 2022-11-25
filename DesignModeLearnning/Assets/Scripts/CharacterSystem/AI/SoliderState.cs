using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SoliderIdleState : FSMState<SoldierTransition, SoldierStateID>
{
    public SoliderIdleState(FSMSystem<SoldierTransition, SoldierStateID> fsm, ICharacter character) : base(fsm, character)
    {
        mStateID = SoldierStateID.Idle;
    }

    private float time = 4;
    public override void Act(List<ICharacter> targets)
    {
        
        Debug.Log("Idleing");//mCharacter.
    }

    public override void Reason(List<ICharacter> targets)
    {
        time -= Time.time;
        if (time <= 0f)
        {
            Debug.Log("Perform Transition");
            mFSM.PerformTransition(SoldierTransition.SeeEnemy);
        }

        if (targets != null && targets.Count > 0)
        {
            mFSM.PerformTransition(SoldierTransition.SeeEnemy);
        }
    }
}

public class SoliderAttackState : FSMState<SoldierTransition, SoldierStateID>
{
    //TODO:
    public SoliderAttackState(FSMSystem<SoldierTransition, SoldierStateID> fsm, ICharacter character) : base(fsm, character)
    {
        mStateID = SoldierStateID.Attack;
    }

    public override void Act(List<ICharacter> targets)
    {
        Debug.Log("Attacking");
    }

    public override void Reason(List<ICharacter> targets)
    {
        throw new NotImplementedException();
    }
}

public class SoliderChaseState : FSMState<SoldierTransition, SoldierStateID>
{
    //TODO:
    public SoliderChaseState(FSMSystem<SoldierTransition, SoldierStateID> fsm, ICharacter character) : base(fsm, character)
    {
        mStateID = SoldierStateID.Chase;
    }

    private float time = 4;
    public override void Act(List<ICharacter> targets)
    {
        Debug.Log("Chasing");
    }

    public override void Reason(List<ICharacter> targets)
    {
        time -= Time.time;
        if (time <= 0f) mFSM.PerformTransition(SoldierTransition.CanAttack);
    }
}

