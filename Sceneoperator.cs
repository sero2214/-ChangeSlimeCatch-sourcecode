using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneoperator : MonoBehaviour
{
    // �{�^���N���b�N�ɂ��V�[���J�ڂ̏����B
    public void SceneLodeoperator(int index)
    {
        if(index == 0)
        {
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.Save();
        }

        Audiomanager.instance.PlaySE(Audiomanager.SE.buttonclick);

        SceneLoder.instance.SceneLode(index);
    }

}
