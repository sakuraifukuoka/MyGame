using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{

    Rigidbody2D rigid2D;
    int count;
    GameObject Player;
    Vector3 Playerpos;

    public static float playerspeed;//�v���C���[�̈ړ����x

    void Start()
    {
        playerspeed = 20;

        this.rigid2D = GetComponent<Rigidbody2D>();
    }


    //�L�[�������ƁA�v���C���[���ړ�����
    void Update()
    {
        Player = GameObject.Find("Player");
        Playerpos = Player.transform.position;
        if (this.transform.position.x > 35)
        {
            this.transform.position = new Vector3(1.9f,Playerpos.y,0);
        }

    }

    void FixedUpdate()
    {
        //�ړ�����

        this.transform.Translate(playerspeed / 50, 0, 0);

    }
}
