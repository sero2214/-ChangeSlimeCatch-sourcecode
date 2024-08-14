using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject[] PanelList;
    [SerializeField] GameObject[] ButtonList;
    
    // 次のページに移動。
    public void PanelRightButton()
    {
        Debug.Log("a");

        for(int i = 0; i < PanelList.Length; i++)
        {
            if (PanelList[i].activeSelf)
            {
                if (i + 1 == 3)
                {
                    ButtonList[1].SetActive(false);
                }

                else if(i + 1 == 1)
                {
                    ButtonList[0].SetActive(true);
                }

                Audiomanager.instance.PlaySE(Audiomanager.SE.buttonclick);

                PanelList[i].SetActive(false);

                PanelList[i + 1].SetActive(true);

                break;
            }

        }

    }

    // 前のページに移動。
    public void PanelLeftButton()
    {
        Debug.Log("a");

        for (int i = 0; i < PanelList.Length; i++)
        {
            if (PanelList[i].activeSelf)
            {
                if (i - 1 == 0)
                {
                    ButtonList[0].SetActive(false);
                }

                else if (i - 1 == 2)
                {
                    ButtonList[1].SetActive(true);
                }

                Audiomanager.instance.PlaySE(Audiomanager.SE.buttonclick);

                PanelList[i].SetActive(false);

                PanelList[i - 1].SetActive(true);

                break;
            }

        }

    }


    // パネルのオンオフ。
    public void PanelOnOff(bool OnOff)
    {
        if (OnOff == true)
        {
            Audiomanager.instance.PlaySE(Audiomanager.SE.buttonclick);

            PanelList[0].SetActive(true);

            ButtonList[1].SetActive(true);

            ButtonList[2].SetActive(true);
        }

        else if(OnOff == false)
        {
            Audiomanager.instance.PlaySE(Audiomanager.SE.buttonclick);

            foreach (GameObject obj in PanelList)
            {
                if(obj.activeSelf)
                {
                    obj.SetActive(false);
                }
            }

            foreach(GameObject obj in ButtonList)
            {
                if(obj.activeSelf)
                {
                    obj.SetActive(false);
                }
            }
        }
    }

}
