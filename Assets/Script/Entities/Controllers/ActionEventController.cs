using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//과제 컨트롤러는 행동 자체에 구독을 받아주는 클래스 입니다.
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


    //invoke의 정확한 의미 공부
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
