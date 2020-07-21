using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectLobby : MonoBehaviour
{
    public Button Level1, Level2;
    private void Awake()
    {
        Level1.onClick.AddListener(level1load);
        Level2.onClick.AddListener(level2load);
    }
    void level1load()
    {
        SceneManager.LoadScene(1);
    }
    void level2load()
    {
        SceneManager.LoadScene(2);
    }
}
