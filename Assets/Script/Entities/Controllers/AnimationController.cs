using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected ActionEventController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<ActionEventController>();
    }
}