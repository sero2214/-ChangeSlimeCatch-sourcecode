using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObject : MonoBehaviour
{
    // ��ʊO�Ɉړ������A�C�e�����A�N�e�B�u�ɂ���B
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }
}
