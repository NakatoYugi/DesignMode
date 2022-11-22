using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLoop : MonoBehaviour
{
    SceneStateController stateController;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        stateController = new SceneStateController();
    }
    private void Start()
    {
        stateController.SetState(new StartState(stateController), false);
    }

    private void Update()
    {
        stateController.StateUpdate();
    }

}
