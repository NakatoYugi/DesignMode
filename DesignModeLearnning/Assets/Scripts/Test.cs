using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public class Test:MonoBehaviour
{
    SoliderFSMSystem SoliderFSMSystem = new SoliderFSMSystem();

    private void Start()
    {
        ICharacter t = new ISolider();
        SoliderIdleState idleState = new SoliderIdleState(SoliderFSMSystem,t);
        idleState.AddTransition(SoldierTransition.SeeEnemy, SoldierStateID.Chase);

        SoliderChaseState chaseState = new SoliderChaseState(SoliderFSMSystem,t);
        chaseState.AddTransition(SoldierTransition.NoEnmey,SoldierStateID.Idle);
        chaseState.AddTransition(SoldierTransition.CanAttack,SoldierStateID.Attack);

        SoliderChaseState attackStaste = new SoliderChaseState(SoliderFSMSystem,t);


        SoliderFSMSystem.AddState(idleState);
        SoliderFSMSystem.AddState(chaseState);
        SoliderFSMSystem.AddState(attackStaste);
    }

    public void Update()
    {
        SoliderFSMSystem.Update();
    }

}

