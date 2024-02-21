using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimations : MonoBehaviour
{
    protected Animator animator;
    protected TopDownCharacterController controller;

    protected virtual void Awake() // 상속받는 객체들이 오버라이드할 수 있게 virtual
    {
        //플레이어에 넣어주면 자식에게서 찾을 수 있게
        animator = GetComponentInChildren<Animator>(); 
        controller = GetComponent<TopDownCharacterController>();

    }


}
