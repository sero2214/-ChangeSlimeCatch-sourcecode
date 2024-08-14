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

    // BGMの種類。
    public enum BGM
    {
        home,
        play
    }

    // 効果音の種類。
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

    // 新たなBGMを流す。
    public void PlayBGM(BGM bgmname)
    {
        if (bgm.isPlaying)
        {
            bgm.Stop();
        }
        bgm.clip = bgmclips[(int)bgmname];
        bgm.Play();
    }

    // 現在流れているBGMを止める。
    public void Audiostop()
    {
        if (bgm.isPlaying)
        {
            bgm.Stop();
        }
    }

    //SEを再生する関数
    public void PlaySE(SE seName)
    {
        se.PlayOneShot(seclips[(int)seName]);
    }

    
}
