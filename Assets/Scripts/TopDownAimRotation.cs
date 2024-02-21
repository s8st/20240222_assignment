using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    private TopDownCharacterController _controller;

    
    void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public  void OnAim(Vector2 direction)
    {
        
        // (x,y)�� ���� ���ϱ�
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //  90���� �������� �¿� ����
        //-�� �ȳ����� ���밪, 
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
