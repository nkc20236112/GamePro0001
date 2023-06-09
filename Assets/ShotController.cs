using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public float speed;//弾のスピード

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // シーン上のオブジェクトと接触したときの処理
    private void OnTriggerEnter2D(Collider2D col)
    {
        // 敵だったら
        if (col.gameObject.tag == "Enemy")
        {
            // ぶつかった相手を破壊
            Destroy(col.gameObject);

            // 弾を破壊
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;//左から右に弾を移動

        //画面右側に消えたら弾を削除
        if (transform.position.x >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
