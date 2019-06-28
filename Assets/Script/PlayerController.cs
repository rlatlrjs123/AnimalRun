using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    GameObject ground;

    public bool isGrounded = false;
    public int jumpCount = 2;
    float jumpForce = 230.0f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.ground = GameObject.Find("ground");
        jumpCount = 0;
    }

    void Update()
    {
        if (isGrounded)
        {
            if (jumpCount > 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    //this.animator.SetTrigger("JumpTrigger");
                    this.rigid2D.AddForce(transform.up * this.jumpForce);
                    jumpCount--;
                }
            }
        }

        if (transform.position.x < -3 || transform.position.y < -3)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;    //Ground에 닿으면 isGround는 true
            jumpCount = 2;          //Ground에 닿으면 점프횟수가 2로 초기화됨
        }
    }
    //if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
    //{
    //    this.animator.SetTrigger("JumpTrigger");
    //    this.rigid2D.AddForce(transform.up * this.jumpForce);
    //}
}

