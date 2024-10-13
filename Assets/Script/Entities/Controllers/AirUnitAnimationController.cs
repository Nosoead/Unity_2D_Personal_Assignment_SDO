using UnityEngine;

public class AirUnitAnimationController : MonoBehaviour, IAnimationController
{

    protected Animator animator;
    protected ActionEventController controller;

    private static readonly int IsFlying = Animator.StringToHash("IsFlying");

    private readonly float magnitudeThreshold = 0.5f;


    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<ActionEventController>();
    }

    private void Start()
    {
        controller.OnMoveEvent += OnMoveAnimation;
    }

    public void OnMoveAnimation(Vector2 obj)
    {
        animator.SetBool(IsFlying, obj.magnitude > magnitudeThreshold);
    }
}