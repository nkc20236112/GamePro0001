using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Speed; //���x
    private float vx; //x���̈ړ���
    GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    void Update()
    {
        //���Ɍ������Ĉړ�����
        transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
        
        //�����蔻��
        Vector2 p1 = transform.position;
        Vector2 p2 = this.Player.transform.position;
        Vector2 p3 = this.Player.transform.position;
        Vector2 dir = p1 - p2;
        Vector2 dir2 = p1 - p3;
        float d=dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.8f;
        float r3 = 0.5f;

        if(d<r1+r2)
        {
            //�ēX�N���v�g�Ƀv���C���ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecresingHp();

            //MtChar�ƏՓ˂����G������
            Destroy(gameObject) ;
        }
        if(d<r1+r3)
        {
            //Myshot�ƏՓ˂����G������
            Destroy(gameObject);
        }

    }
}
