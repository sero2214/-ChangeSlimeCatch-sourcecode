using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialScene : MonoBehaviour
{
    [SerializeField] private Scene scenetyep;

    // �V�[���̎�ށB
    public enum Scene
    {
        home,
        play,
        result
    }

    // �V�[���J�ڂ����n�߂ɂ��ꂼ��ɑΉ�����BGM�𗬂��B
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
