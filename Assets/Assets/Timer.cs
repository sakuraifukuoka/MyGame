using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static int TimeCount;
    int count;
    public GameObject Time;
    // Start is called before the first frame update
    void Start()
    {
        TimeCount = 60;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(TimeCount);
        count++;
        if(count > 50)
        {
            count = 0;
            TimeCount--;
        }
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = Time.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text ="" + TimeCount;
    }
}
