using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //    public float speed = 5f;
    //    private  SpriteRenderer spriteRenderer;
    //    // Start is called before the first frame update
    //    void Start()
    //    {
    //        spriteRenderer = GetComponent<SpriteRenderer>();
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        //float x = Input.GetAxis("Horizontal");
    //        //float y = Input.GetAxis("Vertical");
    //        float x = Input.GetAxisRaw("Horizontal"); // (-1,0,1)
    //        float y = Input.GetAxisRaw("Vertical");
    //        // 대각선은 √2 (≒1.4) 상하좌우는 기본 1크기
    //        // 정규화로 단위벡터 크기 1 인 방향값만 가지게 한다 normalize

    ////        Debug.Log($"{ x},{ y}");

    //        //  transform == gameObject.GetComponent<Transform>();
    //        transform.position += (new Vector3(x,y,0)).normalized * Time.deltaTime*speed;



    //        Vector3 mousePos = Input.mousePosition;

    //        Debug.Log(mousePos);

    //        //Screen.width == 1920
    //        //마우스 위치에 따라 좌우 반전
    //        if(mousePos.x >Screen.width / 2) // 오른쪽
    //        {
    //            spriteRenderer.flipX = false; 
    //        }
    //        else if(mousePos.x <Screen.width /2)
    //        {
    //            spriteRenderer.flipX = true;
    //        }



    //    }

    //////////////////////////////////////////////////////////////////////////////////
    // 위의 방식은 이전 방식  


    private TopDownCharacterController _Controller;

    private Vector2 _movementDirection = Vector2.zero;

    private Rigidbody2D _Rigidbody;

    private void Awake()
    {
        _Controller = GetComponent<TopDownCharacterController>();
        _Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _Controller.OnMoveEvent += Move;
    }

    // 물리법칙은 FixedUpdate에 넣는다
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
       _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5; // direction는 지금 단위벡터, 크기 1인 방향만 가진 벡터

        // transform.position   : 좌표값을 이동하는 방법
        //rigidbody는 마찰력, 질량 등 물리 법칙에 의해 움직임 
        // velocity 방향과 속도, vector2
        _Rigidbody.velocity = direction;
    }


}
