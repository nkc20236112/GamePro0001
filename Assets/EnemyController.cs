using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Speed; //速度
    private float vx; //x軸の移動量
    GameObject Player;

    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    void Update()
    {
        //左に向かって移動する
        transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
        
        //当たり判定
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
            //監督スクリプトにプレイヤと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecresingHp();

            //MtCharと衝突した敵を消す
            Destroy(gameObject) ;
        }
        if(d<r1+r3)
        {
            //Myshotと衝突した敵を消す
            Destroy(gameObject);
        }

    }
}
