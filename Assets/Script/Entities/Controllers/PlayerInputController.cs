using UnityEngine;
using UnityEngine.InputSystem;

//PlayerINputController는 Input Sys에서 값을 받아 일반화 및 구독 호출을 해줍니다.
public class PlayerInputController : ActionEventController
{
    private Camera camera;

    protected override void Awake()
    {
        base.Awake();
        camera = Camera.main;
    }


    //Input sys에서 만든 Move Action에 받은 vector2를 value로 바꿔 SendMessage("OnMove",value)로 내부에서 찾음. 
    public void OnMove(InputValue value)
    {
        //value로 변환된 값을 다시 Vector2값으로 바꿔주고 어느방향이든 1의 값을 갖도록 노말라이즈드를 합니다.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        //Wolrd좌표계로 바꾸고 나서 방향을 계산합니다.
        Vector2 lookDirection = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(lookDirection);
        lookDirection = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(lookDirection);
    }
}