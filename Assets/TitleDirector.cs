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
        //Z��0�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0))
        {
            //�Q�[���V�[���ɐ؂�ւ���
            SceneManager.LoadScene("GameScene");
        }
   }
}