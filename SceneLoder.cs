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

    // 指定したシーンに遷移する
    public void SceneLode(int SceneNumuber)
    {
        SceneManager.LoadScene(SceneNumuber);
    }

}
