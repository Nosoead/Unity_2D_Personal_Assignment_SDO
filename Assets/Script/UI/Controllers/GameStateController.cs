using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameStateType
{
    None,
    Playing,
    Paused
}

public class GameStateController : MonoBehaviour
{

    private GameStateType gamestate;

    public void SetGameState(GameStateType setState)
    {
        gamestate = setState;
        ApplyGameState(gamestate);
    }

    private void ApplyGameState(GameStateType gamestate)
    {
        switch (gamestate)
        {
            case GameStateType.None:
                break;
            case GameStateType.Playing:
                Time.timeScale = 1;
                break;
            case GameStateType.Paused:
                Time.timeScale = 0;
                break;
        }
    }
}
