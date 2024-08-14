using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] int[] CountDowntime;
    [SerializeField] TextMeshProUGUI TimeText;
    [SerializeField] SpriteChange SC;

    private void Start()
    {
        StartCoroutine("CountDown");
    }

    // �����_���Ɍ��߂�ꂽ�b�����B��Ĉ�b���J�E���g���Ă����A�c��ܕb�ɂȂ�ƕ��͂��\������A���ʉ��Ƌ��ɃJ�E���g��0�ɂȂ�܂ő����B
    IEnumerator CountDown()
    {
        TimeText.enabled = false;

        int Countdowntime = CountDowntime[Random.Range(0, CountDowntime.Length)];

        var cashwaittime = new WaitForSeconds(1);

        for(int i = Countdowntime; i > 0; i--)
        {
            if(i > 5)
            {
                yield return cashwaittime;

                Debug.Log(i);

                continue;
            }

            else if(i == 5)
            {
                TimeText.enabled = true;

                SC.Spritedisplay();

                while(i > 0)
                {
                    Audiomanager.instance.PlaySE(Audiomanager.SE.count);

                    TimeText.text = "�c��" + i + "�b";

                    yield return cashwaittime;

                    Debug.Log(i);

                    i--;
                }
            }
        }

        SC.AnimationControllerChange();

        yield return CountDown();
    }
}
