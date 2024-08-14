using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneoperator : MonoBehaviour
{
    // ボタンクリックによるシーン遷移の処理。
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
