using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InitialScoretext : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Highscoretext;
    [SerializeField] TextMeshProUGUI Scoretext;

    // 記録してあるハイスコアを、はじめにスタート画面で表示する。
    void Start()
    {
        int Highscore = PlayerPrefs.GetInt("Highscore");

        Debug.Log(PlayerPrefs.GetInt("Score"));

        Highscoretext.text = "ハイスコア ：" + Highscore;

        if(Scoretext != null)
        {
            int Score = PlayerPrefs.GetInt("Score");

            Scoretext.text = "スコア ：" + Score;
        }
    }


}
