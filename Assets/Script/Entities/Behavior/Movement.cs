using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


//���� å�� ��Ģ : �������� �ް�  ������.
public class Movement : MonoBehaviour
{
    // AssignmentController�� �̺�Ʈ �κи� Ȱ���Ͽ� ������Ű�� �Է¿� ���� �����Դϴ�.
    // �̿����� AssignmentController�� ���� ������ Rigidbody2D�� �ӵ��� �ʿ��մϴ�.

    private ActionEventController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;


    //Awake�� �ַ� �ش� ������Ʈ���� ������ �͵� �ʱⰪ
    private void Awake()
    {
        controller = GetComponent<ActionEventController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // ��Ʈ�ѷ��� �ִ� OnMoveEvent�� ���� (�ִϸ��̼ǿ����� �����ϸ� ��Ƽĳ��Ʈ ��������Ʈ)
        //OnMoveEvent�� Action<Vector2>�� ���� ���� --> �Ű������� �� Vector2
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
    {   //�����ѹ� --> ���߿� ĳ���� ���ó����� �����ϱ�
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
