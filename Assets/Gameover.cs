using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public string SameLevel;
    public Button restart;
   public PlayerController PlayerController;
    void Start ()
    {
        restart.onClick.AddListener(SameSceneReload);
    }

    public void ReloadScene()
    {
        gameObject.SetActive(true);
        PlayerController.enabled = false;
        
    }
    public void SameSceneReload()
    {
        Debug.Log("button");
        SceneManager.LoadScene(SameLevel);
    }
}
