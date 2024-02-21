using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event사용시 외부 클래스에서 사용못하고 내부에서만 사용가능
    //public delegate void OnMoveDel(Vector2 direction);
    //public event OnMoveDel OnMoveEvent;

    // Action<Vector2> --->using System;필요
    // public delegate void OnMoveDel(Vector2 direction);
    public event Action<Vector2> OnMoveEvent;

    // 반환값이 있으면 Func, 반호나값 없으면 Action
    // public delegate int OnMoveDel(Vector2 direction);
    // public event Func<Vector2> OnMoveEvent;
    ////////////////////////////////////////////////////////////////

    //public delegate  void OnLookDel(Vector2 direction);
    //public OnLookDel OnLookEvent;


    public event Action<Vector2> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
