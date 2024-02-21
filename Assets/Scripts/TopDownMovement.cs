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
    //        // �밢���� ��2 (��1.4) �����¿�� �⺻ 1ũ��
    //        // ����ȭ�� �������� ũ�� 1 �� ���Ⱚ�� ������ �Ѵ� normalize

    ////        Debug.Log($"{ x},{ y}");

    //        //  transform == gameObject.GetComponent<Transform>();
    //        transform.position += (new Vector3(x,y,0)).normalized * Time.deltaTime*speed;



    //        Vector3 mousePos = Input.mousePosition;

    //        Debug.Log(mousePos);

    //        //Screen.width == 1920
    //        //���콺 ��ġ�� ���� �¿� ����
    //        if(mousePos.x >Screen.width / 2) // ������
    //        {
    //            spriteRenderer.flipX = false; 
    //        }
    //        else if(mousePos.x <Screen.width /2)
    //        {
    //            spriteRenderer.flipX = true;
    //        }



    //    }

    //////////////////////////////////////////////////////////////////////////////////
    // ���� ����� ���� ���  


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

    // ������Ģ�� FixedUpdate�� �ִ´�
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
        direction *= 5; // direction�� ���� ��������, ũ�� 1�� ���⸸ ���� ����

        // transform.position   : ��ǥ���� �̵��ϴ� ���
        //rigidbody�� ������, ���� �� ���� ��Ģ�� ���� ������ 
        // velocity ����� �ӵ�, vector2
        _Rigidbody.velocity = direction;
    }


}
