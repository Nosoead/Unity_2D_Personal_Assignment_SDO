using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private ButtonController buttoncontroller;
    private GameStateController gmaeStateController;
    [SerializeField] GameStateType gameState;

    private void Awake()
    {
        buttoncontroller = GetComponent<ButtonController>();
        gmaeStateController = GetComponent<GameStateController>();
    }

    private void Start()
    {
        buttoncontroller.OnButtonEvent += OnGameStatChanger;
    }

    private void OnGameStatChanger()
    {
        gmaeStateController.SetGameState(gameState);
    }
}
