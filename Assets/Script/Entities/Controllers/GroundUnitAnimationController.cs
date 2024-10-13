using UnityEngine;
public class GroundUnitAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    private readonly float magnitudeThreshold = 0.5f;


    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += OnMoveAnimation;
    }

    private void OnMoveAnimation(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnitudeThreshold);
    }
}