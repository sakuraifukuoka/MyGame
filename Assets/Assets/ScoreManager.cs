using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public GameObject score_object = null;
    public static int score_num;//�X�R�A�ϐ�
    public static int score_count;
    void Start()
    {
        score_num = 0;
        score_count = 0;

    }


    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "Score" + score_num;
    }
}