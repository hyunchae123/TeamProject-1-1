using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Skeleton : Bringer
{
    public Skeleton()
    {
        EnemyPower = 15;
        moveSpeed = 5;
        EXP = 450;
    }


    private new void Movement()
    {
        if (GameManager.Instance.isPause == true)
        {
            return;
        }

        if (StatusManager.Instance.isDead == true)
        {
            return;
        }

        Collider2D player = Physics2D.OverlapCircle(transform.position, 10f, PlayerMask);
        
        if (player != null)
        {
            Vector2 dir = target.position - transform.position;
            dir.Normalize();
            anim.SetFloat("velocityX", dir.x);
            anim.SetFloat("velocityY", dir.y);
            rigid.velocity = new Vector2(dir.x * moveSpeed, dir.y * moveSpeed);
        }
        else
        {
            Vector2 dir = new Vector2(0, 0);
            anim.SetFloat("velocityX", dir.x);
            anim.SetFloat("velocityY", dir.y);
            rigid.velocity = new Vector2(dir.x * moveSpeed, dir.y * moveSpeed);
        }
        
    }

}
