using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform groundDetector;
    private Animator ani;
    private bool isdead;
    private float runlength;
    private int jumpcount;

    // Use this for initialization
    void Awake()
    {
        groundDetector = transform.GetChild(0);
        ani = gameObject.GetComponent<Animator>();
        isdead = false;
        runlength = 0.0f;
        jumpcount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (isdead) return;

        runlength += Time.deltaTime;
    }
    
    public void OnClickJumpButton()
    {
        SetJump();
    }

    public void OnClickAttackButton()
    {
        SetAttack();
    }


    public void SetJump()
    {
        if (isdead) return;

        RaycastHit2D hit = Physics2D.Linecast(transform.position, groundDetector.position);

        if (hit.transform != null)
        {
            jumpcount = 2;
        }

        if (Input.GetMouseButtonDown(0) && jumpcount > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 300.0f));

            jumpcount--;
        }
    }
    private void SetAttack()
    {
        if (isdead) return;

        ani.SetTrigger("Attack");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            ani.SetTrigger("Hit");
            isdead = true;            

            // "Ground" �±׸� ������ �ִ� ������Ʈ 5���� SendMessage
            for (int i = 0; i < 5; i++)
            {
                GameObject.FindGameObjectsWithTag("Ground")[i].SendMessage("StopScroll");
            }
            // "Pooling" �±׸� ������ �ִ� ������Ʈ�� SendMessage
            GameObject.FindGameObjectWithTag("Pooling").SendMessage("DisableObject");

            OnDeath();
            
            //print("�浹�߽��ϴ�");
        }
    }

    void OnDeath()
    {
        if (isdead == false) return;

        Invoke("CallScoreBoard", 3f);
    }

    void CallScoreBoard()
    {
        Popups.instance.UpScoreBoard();
    }
}
