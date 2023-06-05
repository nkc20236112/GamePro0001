using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    float score;
    void Start()
    {
        score = GameDirector.score;
        ScoreText.text = string.Format("Score:{0}", (int)score);
    }

    void Update()
    {
        
    }
}
