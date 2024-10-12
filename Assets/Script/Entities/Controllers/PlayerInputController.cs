using UnityEngine;
using UnityEngine.InputSystem;

//PlayerINputController�� Input Sys���� ���� �޾� �Ϲ�ȭ �� ���� ȣ���� ���ݴϴ�.
public class PlayerInputController : ActionEventController
{
    private Camera camera;

    protected override void Awake()
    {
        base.Awake();
        camera = Camera.main;
    }


    //Input sys���� ���� Move Action�� ���� vector2�� value�� �ٲ� SendMessage("OnMove",value)�� ���ο��� ã��. 
    public void OnMove(InputValue value)
    {
        //value�� ��ȯ�� ���� �ٽ� Vector2������ �ٲ��ְ� ��������̵� 1�� ���� ������ �븻������带 �մϴ�.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        //Wolrd��ǥ��� �ٲٰ� ���� ������ ����մϴ�.
        Vector2 lookDirection = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(lookDirection);
        lookDirection = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(lookDirection);
    }
}