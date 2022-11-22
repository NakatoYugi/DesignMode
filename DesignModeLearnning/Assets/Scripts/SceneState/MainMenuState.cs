using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateController controller) : base("MainMenuScene", controller)
    {
    }

    public override void StateStart()
    {
        Debug.Log("Enter MainMenuScene");
        GameObject.Find("StartButton").GetComponent<Button>().onClick.AddListener(OnStartButtonClick);
    }

    private void OnStartButtonClick()
    {
        Debug.Log("Go to BattleScene");
        mController.SetState(new BattleState(mController));
    }
}

