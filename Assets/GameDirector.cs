using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject kyoriText;
    float kyori = 0;

    public Text ScoreText;
    public static float score = 0;


    void Start()
    {
        Application.targetFrameRate = 60;

        this.hpGauge = GameObject.Find("hpGauge");
        this.kyoriText = GameObject.Find("kyori");
    }

    public void DecresingHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {
        this.kyori += 60 * Time.deltaTime;

        score = this.kyori;

        this.kyoriText.GetComponent<TextMeshProUGUI>().text=this.kyori.ToString("000000"+"km");

        this.hpGauge.GetComponent<Image>().fillAmount -= Time.deltaTime / 100;

        if (hpGauge.GetComponent<Image>().fillAmount <= 0.001f)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
