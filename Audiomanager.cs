using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;

    [SerializeField] private AudioClip[] bgmclips;
    [SerializeField] private AudioClip[] seclips;

    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource se;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // BGM�̎�ށB
    public enum BGM
    {
        home,
        play
    }

    // ���ʉ��̎�ށB
    public enum SE
    {
        minisuccess,
        success,
        miss,
        death,
        result, 
        buttonclick,
        count,
        change
    }

    // �V����BGM�𗬂��B
    public void PlayBGM(BGM bgmname)
    {
        if (bgm.isPlaying)
        {
            bgm.Stop();
        }
        bgm.clip = bgmclips[(int)bgmname];
        bgm.Play();
    }

    // ���ݗ���Ă���BGM���~�߂�B
    public void Audiostop()
    {
        if (bgm.isPlaying)
        {
            bgm.Stop();
        }
    }

    //SE���Đ�����֐�
    public void PlaySE(SE seName)
    {
        se.PlayOneShot(seclips[(int)seName]);
    }

    
}
