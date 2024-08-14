using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InitialScoretext : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Highscoretext;
    [SerializeField] TextMeshProUGUI Scoretext;

    // �L�^���Ă���n�C�X�R�A���A�͂��߂ɃX�^�[�g��ʂŕ\������B
    void Start()
    {
        int Highscore = PlayerPrefs.GetInt("Highscore");

        Debug.Log(PlayerPrefs.GetInt("Score"));

        Highscoretext.text = "�n�C�X�R�A �F" + Highscore;

        if(Scoretext != null)
        {
            int Score = PlayerPrefs.GetInt("Score");

            Scoretext.text = "�X�R�A �F" + Score;
        }
    }


}
