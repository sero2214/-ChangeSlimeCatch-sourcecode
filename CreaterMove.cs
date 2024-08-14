using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterMove : MonoBehaviour
{
    [SerializeField] Transform Starttransform;
    [SerializeField] Transform Finishtransform;
    [SerializeField] float Movespeed;

    private void Start()
    {
        StartCoroutine("ItemCreaterMove", false);
    }

    // 上部から降るアイテムを生成するオブジェクトが、一定範囲内を移動し続ける処理。
    IEnumerator ItemCreaterMove(bool back)
    {
        float Counttime = 0;

        Vector3 starttransform = new Vector3(0, 0, 0);
        Vector3 finishtransform = new Vector3(0, 0, 0);

        if (back == false)
        {
            starttransform = Starttransform.position;
            finishtransform = Finishtransform.position;
        }

        else if (back == true)
        {
            starttransform = Finishtransform.position;
            finishtransform = Starttransform.position;
        }

        while (Counttime <= Movespeed)
        {
            this.transform.position = Vector3.Lerp(starttransform, finishtransform, Counttime / Movespeed);
            Counttime += Time.deltaTime;
            yield return null;
        }

        if (back == false)
        {
            StartCoroutine("ItemCreaterMove", true);
        }

        else if(back == true)
        {
            StartCoroutine("ItemCreaterMove", false);
        }
    }
    
}
