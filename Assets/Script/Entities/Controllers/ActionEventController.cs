using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ��Ʈ�ѷ��� �ൿ ��ü�� ������ �޾��ִ� Ŭ���� �Դϴ�.
public class ActionEventController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    protected virtual void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //invoke�� ��Ȯ�� �ǹ� ����
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
