using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float MoveSpeed;
    [SerializeField] GameObject gameManager;
    public bool isRightMove;
    public bool isLeftMove;
    bool isMove = true;
    SpriteRenderer SR;
    Animator PA;
    BoxCollider2D BC;
    Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        PA = this.GetComponent<Animator>();

        SR = this.GetComponent<SpriteRenderer>();

        BC = this.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Move();
    }

    // ←→ボタンによるプレイヤーの左右の移動。
    void Move()
    {
        if (isMove == true)
        {

            if (Input.GetKey(KeyCode.RightArrow) && isLeftMove == false)
            {
                isRightMove = true;

                SR.flipX = true;

                PA.SetBool("Run", true);

                rb.velocity = new Vector3(MoveSpeed, 0, 0);
            }

            else if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                isRightMove = false;

                SR.flipX = false;

                PA.SetBool("Run", false);

                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow) && isRightMove == false)
            {
                isLeftMove = true;

                PA.SetBool("Run", true);

                rb.velocity = new Vector3(-MoveSpeed, 0, 0);
            }

            else if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                isLeftMove = false;

                PA.SetBool("Run", false);

                rb.velocity = new Vector3(0, 0, 0);
            }

        }

    }

    // ゲームオーバー時の処理。
    public void playerdeath()
    {
        isMove = false;

        rb.velocity = new Vector3(0, 0, 0);

        BC.enabled = false;

        gameManager.SetActive(false);

        Audiomanager.instance.PlaySE(Audiomanager.SE.death);

        PA.SetBool("death", true);
    }

    // リザルト画面への遷移
    public void resultsceneLode()
    {
        int index = 2;

        SceneLoder.instance.SceneLode(index);
    }

}
