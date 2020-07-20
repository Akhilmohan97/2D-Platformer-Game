using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public string SameLevel;
    public Button restart;
    void Start ()
    {
        restart.onClick.AddListener(SameSceneReload);
    }

    public void ReloadScene()
    {
        gameObject.SetActive(true);
    }
    public void SameSceneReload()
    {
        Debug.Log("button");
        SceneManager.LoadScene(SameLevel);
    }
}
