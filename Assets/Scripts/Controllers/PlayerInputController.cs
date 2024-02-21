using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
        CallMoveEvent(moveInput); //TopDownCharacterController�� CallMoveEvent()�� ����

    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // ���콺 �������� ��ũ�� ���� ��ġ

        // Camera.main --> ����Ƽ �ν����Ϳ��� maincamera�� �ִ� ������Ʈ
        //��ũ���� ��ǥ���� ī�޶� �ִ�
        // ��ũ�� ���� ���콺 �����͸� ������ǥ������ ����
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim); //���콺�� ������ǥ��

        // (���콺 ��ǥ�� - �� ��ǥ��).����ȭ -- normalized : ���⸸ �˰� ������
        // worldPos : Vector2  
        // transform.position :Vector3
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);

    }
}
