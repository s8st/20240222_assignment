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
        CallMoveEvent(moveInput); //TopDownCharacterController에 CallMoveEvent()이 있음

    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // 마우스 포인터의 스크린 상의 위치

        // Camera.main --> 유니티 인스펙터에서 maincamera에 있는 컴포넌트
        //스크린의 좌표값은 카메라에 있다
        // 스크린 상의 마우스 포인터를 월드좌표값으로 변경
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim); //마우스의 월드좌표값

        // (마우스 좌표값 - 내 좌표값).정규화 -- normalized : 방향만 알고 싶을때
        // worldPos : Vector2  
        // transform.position :Vector3
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);

    }
}
