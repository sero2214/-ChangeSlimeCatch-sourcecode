using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePower : MonoBehaviour
{
    [SerializeField] float[] Movepower;
    [SerializeField] Rigidbody2D rb;

    // 始めにアイテムの動く距離をランダムに決定。
    void OnEnable()
    {
        rb.velocity = new Vector3(Movepower[Random.Range(0, Movepower.Length)], 0, 0);
    }

}
