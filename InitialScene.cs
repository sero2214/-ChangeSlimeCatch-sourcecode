using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialScene : MonoBehaviour
{
    [SerializeField] private Scene scenetyep;

    // シーンの種類。
    public enum Scene
    {
        home,
        play,
        result
    }

    // シーン遷移した始めにそれぞれに対応したBGMを流す。
    void Start()
    {
        switch(scenetyep)
        {
            case Scene.home:
                Audiomanager.instance.PlayBGM(Audiomanager.BGM.home);
                break;

            case Scene.play:
                Audiomanager.instance.PlayBGM(Audiomanager.BGM.play);
                break;

            case Scene.result:
                Audiomanager.instance.Audiostop();

                Audiomanager.instance.PlaySE(Audiomanager.SE.result);
                break;

        }
    }

}
