using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] PlayerMove PM;
    [SerializeField] TextMeshProUGUI ScoreTMP;
    [SerializeField] TextMeshProUGUI FailTMP;
    [SerializeField] int bigadd;
    [SerializeField] int littleadd;
    int scorenum;
    int Misscount;


    // 触れたアイテムの属性がスライムの得意なものだったらスコア大アップ、不得意なものだったらミスカウント増、どちらでもないならスコア小アップする。
    public void Hitjudgement(bool success, bool bigup = false)
    {

        if(success == true)
        {
            if (bigup == true)
            {
                scorenum += bigadd;

                ScoreTMP.text = "スコア： " + scorenum;

                Audiomanager.instance.PlaySE(Audiomanager.SE.success);
            }

            else
            {
                scorenum += littleadd;

                ScoreTMP.text = "スコア： " + scorenum;

                Audiomanager.instance.PlaySE(Audiomanager.SE.minisuccess);
            }
        }

        else if(success == false)
        {
            Misscount += 1;

            FailTMP.text = "ミス： " + Misscount;

            if(Misscount >= 5)
            {
                HighScoreSave();

                Debug.Log(PlayerPrefs.GetInt("Highscore"));

                PM.playerdeath();
            }

            else
            {
                Audiomanager.instance.PlaySE(Audiomanager.SE.miss);
            }
        }
    }


    // ゲームオーバー時のスコアが自身の最高スコアを超えていたら、そのスコアをハイスコアとして保存する。
    private void HighScoreSave()
    {
        int nowHighscore = PlayerPrefs.GetInt("Highscore");

        PlayerPrefs.SetInt("Score", scorenum);

        if(nowHighscore < scorenum)
        {
            PlayerPrefs.SetInt("Highscore", scorenum);
        }

        PlayerPrefs.Save();
    }

}
