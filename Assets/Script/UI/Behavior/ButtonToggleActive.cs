using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggleActive : MonoBehaviour
{
    private ButtonController controller;
    [SerializeField] private GameObject targetObject;
    private void Awake()
    {
        controller = GetComponent<ButtonController>();
    }

    void Start()
    {
        controller.OnButtonEvent += OnToggleActive;
    }

    private void OnToggleActive()
    {
        targetObject.SetActive(!targetObject.activeSelf);
    }
}
