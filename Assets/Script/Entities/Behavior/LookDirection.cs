using UnityEngine;

public class LookDirection : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Transform characterTransform;

    private ActionEventController controller;

    private void Awake()
    {
        controller = GetComponent<ActionEventController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnLookDirection;
    }

    private void OnLookDirection(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //������ 90������ ũ�� 2,3��и�
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        characterTransform.rotation = Quaternion.Euler(0, 0, rotZ);

    }
}