using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BattleState : ISceneState
{
    public BattleState(SceneStateController controller) : base("BattleScene", controller)
    {

    }

    public override void StateStart()
    {
        GameFacade.Instance.Init();
    }

    public override void StateEnd()
    {
        GameFacade.Instance.Release();
    }

    public override void StateUpdate()
    {
        if (GameFacade.Instance.IsGameOver) mController.SetState(new MainMenuState(mController));

        GameFacade.Instance.Update();
    }
}

