using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinContoroller : MonoBehaviour
{
    int count;
    public AudioClip se;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(count == 100)
        {
            ScoreManager.score_num += 1000;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //�v���C���[�ɐG�ꂽ��R�C����������悤�ɏ�������
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.score_num += 100;
            ScoreManager.score_count += 1;
            AudioSource.PlayClipAtPoint(se,transform.position);
            Destroy(this.gameObject);
        }
    }
}
