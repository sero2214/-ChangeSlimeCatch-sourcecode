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

    // ���݂Ƃ͈قȂ�A�j���[�V�����R���g���[���[�Ɍ��肷��B
   �@private void Controllerdecision()
    {
        ControllerSelect();

        while(PlayerA.runtimeAnimatorController == ChangeAc)
        {
            ControllerSelect();
        }

        Debug.Log(ACnumber);

        SR.sprite = Allsprite[ACnumber];

    }

    // ���݂Ƃ͈قȂ�A�j���[�V�����R���g���[���[��I������B
    private void ControllerSelect()
    {
        ACnumber = Random.Range(0, AllAC.Length);

        ChangeAc = AllAC[ACnumber];
    }

    // �ȑO�Ƃ͈قȂ�A�j���[�V�����R���g���[���[�ɕύX����B
    public void AnimationControllerChange()
    {
        SR.enabled = false;

        Audiomanager.instance.PlaySE(Audiomanager.SE.change);

        PlayerA.runtimeAnimatorController = ChangeAc;

        player.gameObject.tag = tagobject[ACnumber].tag;

        Controllerdecision();
    }

    // �J�E���g���ܕb�ȉ��ɂȂ����ۂɁA���ɕω����鑮���̃X���C���̉摜��\������B
    public void Spritedisplay()
    {
        SR.enabled = true;
    }
   
}
