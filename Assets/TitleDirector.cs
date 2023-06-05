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
        //Z‚©0‚ª‰Ÿ‚³‚ê‚½‚ç
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0))
        {
            //ƒQ[ƒ€ƒV[ƒ“‚ÉØ‚è‘Ö‚¦‚é
            SceneManager.LoadScene("GameScene");
        }
   }
}