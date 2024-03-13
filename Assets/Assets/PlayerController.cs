using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigid2D;
    float jumpForce = 1020.0f;
    bool isJumpFlag;
    int count;

    public static float playerspeed;//�v���C���[�̈ړ����x

    void Start()
    {
        playerspeed = 20;

        isJumpFlag = true;

        this.rigid2D = GetComponent<Rigidbody2D>();
    }


    //�L�[�������ƁA�v���C���[���ړ�����
    void Update()
    {
        if (Input.GetKey("left"))
        {
            playerspeed = 10;
        }
        else if (Input.GetKey("right"))
        {
            playerspeed = 30;
        }
        else
        {
            playerspeed = 20;
        }

        if (isJumpFlag)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rigid2D.AddForce(transform.up * this.jumpForce);
                isJumpFlag = false;
            }
        }


    }

    void FixedUpdate()
    {
        if(isJumpFlag == false)
        {
            count++;
            if(count > 35)
            {
                isJumpFlag = true;
                count = 0;
            }
        }

        //�ړ�����

        this.transform.Translate(playerspeed / 50, 0, 0);

    }
}
