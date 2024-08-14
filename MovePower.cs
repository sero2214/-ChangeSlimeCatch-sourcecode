using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePower : MonoBehaviour
{
    [SerializeField] float[] Movepower;
    [SerializeField] Rigidbody2D rb;

    // �n�߂ɃA�C�e���̓��������������_���Ɍ���B
    void OnEnable()
    {
        rb.velocity = new Vector3(Movepower[Random.Range(0, Movepower.Length)], 0, 0);
    }

}
