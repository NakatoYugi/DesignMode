using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GameFacade
{
    private bool mIsGameOver;
    public bool IsGameOver { get { return mIsGameOver; } }

    private static GameFacade _instance = new GameFacade();
    private GameFacade() { }
    public static GameFacade Instance { get { return _instance; } }

    public void Init()
    { 
    }

    public void Update()
    { 
    }

    public void Release()
    { 
    }
}

