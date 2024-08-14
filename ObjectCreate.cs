using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreate : MonoBehaviour
{
    [SerializeField] float spawnTime;
    [SerializeField] GameObject[] InstantiateobjectList;
    [SerializeField] List<GameObject> BlueportionList;
    [SerializeField] List<GameObject> RedportionList;
    [SerializeField] List<GameObject> GreenportionList;
    private List<GameObject>[] CreateobjectList = new List<GameObject>[3];

    void Start()
    {
        Listinsert();

        StartCoroutine("Creator");
    }

    // 降り注ぐアイテムの生成処理。
    IEnumerator Creator()
    {
        List<GameObject> selectList;
        GameObject InstantiateObject;
        int Listnumber;
        var spawntime = new WaitForSeconds(spawnTime);

        while(true)
        {
            //selectList = CreateobjectList[Random.Range(0, CreateobjectList.Length)];

            Listnumber = Random.Range(0, CreateobjectList.Length);

            selectList = CreateobjectList[Listnumber];

            for(int i = 0; i < selectList.Count; i++)
            {
                if (!selectList[i].activeSelf)
                {
                    selectList[i].transform.position = this.transform.position;

                    selectList[i].SetActive(true);
                    break;
                }

                else if(i + 1 == selectList.Count && selectList[i].activeSelf)
                {
                    InstantiateObject = Instantiate(selectList[0], transform.position, transform.rotation);

                    InstantiateObject.transform.parent = InstantiateobjectList[Listnumber].transform;

                    CreateobjectList[Listnumber].Add(InstantiateObject);
                    break;
                }

            }

            yield return spawntime; 
        }
    }

    void Listinsert()
    {
        CreateobjectList[0] = BlueportionList;
        CreateobjectList[1] = RedportionList;
        CreateobjectList[2] = GreenportionList;
    }
}
