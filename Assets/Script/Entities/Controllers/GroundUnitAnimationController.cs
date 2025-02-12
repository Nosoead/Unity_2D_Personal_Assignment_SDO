using UnityEngine;
public class GroundUnitAnimationController : MonoBehaviour, IAnimationController
{

    protected Animator animator;
    protected ActionEventController controller;

    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

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
        animator.SetBool(IsWalking, obj.magnitude > magnitudeThreshold);
    }
}