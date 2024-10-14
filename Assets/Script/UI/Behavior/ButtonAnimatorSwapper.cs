using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimatorSwapper : MonoBehaviour
{
    private ButtonController controller;
    private RuntimeAnimatorController currentAnimatorController;

    [SerializeField] private Animator selectedAnimator;
    [SerializeField] private Animator targetAnimator;

    private void Awake()
    {
        controller = GetComponent<ButtonController>();
        currentAnimatorController = targetAnimator.runtimeAnimatorController;
    }

    void Start()
    {
        controller.OnButtonEvent += OnAnimatorSwap;
    }

    private void OnAnimatorSwap()
    {
        if (selectedAnimator != null)
        {
            currentAnimatorController = selectedAnimator.runtimeAnimatorController;
            ApplyAnimatorSwap();
        }
    }

    private void ApplyAnimatorSwap()
    {
        if (currentAnimatorController !=null &&
            targetAnimator.runtimeAnimatorController !=null)
        {
            targetAnimator.runtimeAnimatorController = currentAnimatorController;
        }
    }
}
