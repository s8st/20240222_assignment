using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimations : MonoBehaviour
{
    protected Animator animator;
    protected TopDownCharacterController controller;

    protected virtual void Awake() // ��ӹ޴� ��ü���� �������̵��� �� �ְ� virtual
    {
        //�÷��̾ �־��ָ� �ڽĿ��Լ� ã�� �� �ְ�
        animator = GetComponentInChildren<Animator>(); 
        controller = GetComponent<TopDownCharacterController>();

    }


}
