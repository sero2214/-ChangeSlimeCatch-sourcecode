using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoder : MonoBehaviour
{
    public static SceneLoder instance;

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

    // �w�肵���V�[���ɑJ�ڂ���
    public void SceneLode(int SceneNumuber)
    {
        SceneManager.LoadScene(SceneNumuber);
    }

}
