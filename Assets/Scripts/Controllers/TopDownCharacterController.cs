using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event���� �ܺ� Ŭ�������� �����ϰ� ���ο����� ��밡��
    //public delegate void OnMoveDel(Vector2 direction);
    //public event OnMoveDel OnMoveEvent;

    // Action<Vector2> --->using System;�ʿ�
    // public delegate void OnMoveDel(Vector2 direction);
    public event Action<Vector2> OnMoveEvent;

    // ��ȯ���� ������ Func, ��ȣ���� ������ Action
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
