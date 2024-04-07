using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bringer : Enemy
{
    public Bringer()
    {
        EnemyPower = 12;
        moveSpeed = 5;
        EXP = 350;
    }

    private new void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerStatus = collision.gameObject.GetComponent<StatusManager>();
            anim.SetBool("onAttack", true);
        }
    }

    private new void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerStatus = null;
            anim.SetBool("onAttack", false);
        }
    }

    private new void Update()
    {
        if (EnemyStatus.isDead == true)
        {
            anim.SetTrigger("onDead");
        }

        if ((GameManager.Instance.onSturn == true && strunTime > 0.5f) || (GameManager.Instance.onSturn == true && strunTime == 0.0f) || GameManager.Instance.onSturn == false)
        {
            Movement();
        }
    }

    public new void OnSlow()
    {
        moveSpeed -= moveSpeed * 0.5f;
    }

    public void Movement()
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
            anim.SetBool("isWalk", true);
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }

        if ((target.transform.position - transform.position).x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

}
