using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : TopDownAnimations
{
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Animation;
    }

   public void Animation(Vector2 direction)
    {
        // magnitude : 벡터의 크기 반환
        animator.SetBool("IsWalking",direction.magnitude >0f); // 0 -정지 , 1 - 움직임
    }
}
