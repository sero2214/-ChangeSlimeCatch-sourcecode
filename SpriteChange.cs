using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [SerializeField] RuntimeAnimatorController[] AllAC;
    [SerializeField] Sprite[] Allsprite;
    [SerializeField] GameObject[] tagobject;
    [SerializeField] GameObject player;
    [SerializeField] SpriteRenderer SR;
    [SerializeField] Animator PlayerA;
    private int ACnumber;
    public RuntimeAnimatorController ChangeAc;

    private void Start()
    {
        Controllerdecision();
    }

    // 現在とは異なるアニメーションコントローラーに決定する。
   　private void Controllerdecision()
    {
        ControllerSelect();

        while(PlayerA.runtimeAnimatorController == ChangeAc)
        {
            ControllerSelect();
        }

        Debug.Log(ACnumber);

        SR.sprite = Allsprite[ACnumber];

    }

    // 現在とは異なるアニメーションコントローラーを選択する。
    private void ControllerSelect()
    {
        ACnumber = Random.Range(0, AllAC.Length);

        ChangeAc = AllAC[ACnumber];
    }

    // 以前とは異なるアニメーションコントローラーに変更する。
    public void AnimationControllerChange()
    {
        SR.enabled = false;

        Audiomanager.instance.PlaySE(Audiomanager.SE.change);

        PlayerA.runtimeAnimatorController = ChangeAc;

        player.gameObject.tag = tagobject[ACnumber].tag;

        Controllerdecision();
    }

    // カウントが五秒以下になった際に、次に変化する属性のスライムの画像を表示する。
    public void Spritedisplay()
    {
        SR.enabled = true;
    }
   
}
