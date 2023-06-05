using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    void Start()
    {

    }
   void Update()
    {
        //Zか0が押されたら
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0))
        {
            //ゲームシーンに切り替える
            SceneManager.LoadScene("GameScene");
        }
   }
}