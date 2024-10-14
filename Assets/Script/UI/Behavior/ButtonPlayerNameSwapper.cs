using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayerNameSwapper : MonoBehaviour
{
    private ButtonController controller;

    [SerializeField] private Text playerInputName;
    [SerializeField] private Text targetName;
    private Text currentName;
    private void Awake()
    {
        controller = GetComponent<ButtonController>();
        currentName = targetName;
    }

    void Start()
    {
        controller.OnButtonEvent += OnPlayerNameSwap;
    }

    private void OnPlayerNameSwap()
    {
        currentName.text = playerInputName.text;
        ApplyPlayerNameSwap();
    }

    private void ApplyPlayerNameSwap()
    {
        if (currentName != targetName)
        {
            targetName.text = currentName.text;
        }
    }
}
