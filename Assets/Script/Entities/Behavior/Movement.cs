using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


//단일 책임 원칙 : 움직입을 받고  움직임.
public class Movement : MonoBehaviour
{
    // AssignmentController의 이벤트 부분만 활용하여 구독시키면 입력에 따라 움직입니다.
    // 이에따라 AssignmentController와 실제 움직일 Rigidbody2D의 속도가 필요합니다.

    private ActionEventController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;


    //Awake는 주로 해당 컴포넌트에서 끝나는 것들 초기값
    private void Awake()
    {
        controller = GetComponent<ActionEventController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // 컨트롤러에 있는 OnMoveEvent에 구독 (애니메이션에서도 구독하면 멀티캐스트 델리게이트)
        //OnMoveEvent는 Action<Vector2>의 구독 집합 --> 매개변수는 늘 Vector2
        controller.OnMoveEvent += OnMovement;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }


    private void OnMovement(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {   //매직넘버 --> 나중에 캐릭터 선택나오면 수정하기
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
