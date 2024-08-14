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


    // �G�ꂽ�A�C�e���̑������X���C���̓��ӂȂ��̂�������X�R�A��A�b�v�A�s���ӂȂ��̂�������~�X�J�E���g���A�ǂ���ł��Ȃ��Ȃ�X�R�A���A�b�v����B
    public void Hitjudgement(bool success, bool bigup = false)
    {

        if(success == true)
        {
            if (bigup == true)
            {
                scorenum += bigadd;

                ScoreTMP.text = "�X�R�A�F " + scorenum;

                Audiomanager.instance.PlaySE(Audiomanager.SE.success);
            }

            else
            {
                scorenum += littleadd;

                ScoreTMP.text = "�X�R�A�F " + scorenum;

                Audiomanager.instance.PlaySE(Audiomanager.SE.minisuccess);
            }
        }

        else if(success == false)
        {
            Misscount += 1;

            FailTMP.text = "�~�X�F " + Misscount;

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


    // �Q�[���I�[�o�[���̃X�R�A�����g�̍ō��X�R�A�𒴂��Ă�����A���̃X�R�A���n�C�X�R�A�Ƃ��ĕۑ�����B
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
