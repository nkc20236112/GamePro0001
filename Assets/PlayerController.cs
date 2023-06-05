using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    //インスペクターウィンドウでspeedを変更できる
    public float speed = 1;

    private Rigidbody2D rb;

    //弾のプレハブ
    public GameObject MyShotPrefab;

    private Animator anim;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x=Input.GetAxisRaw("Horizontal");
        dir.y=Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;

        if (dir.y == 0)
        {
            anim.Play("Player");
        }
        else if (dir.y == 1) 
        {
            anim.Play("PlayerL");
        }
        else
        {
            anim.Play("PlayerR");
        }



        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")||Input.GetKey("g"))
        {
            GameObject tama = Instantiate(MyShotPrefab);
            tama.transform.position = transform.position;

        }
        //
    }
}