using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    
    public Button restart, Lobby;
   public PlayerController PlayerController;
    void Start ()
    {
        restart.onClick.AddListener(SameSceneReload);
        Lobby.onClick.AddListener(lobby);
    }

    public void ReloadScene()
    {
        gameObject.SetActive(true);
        PlayerController.enabled = false;
        
    }
    public void SameSceneReload()
    {
        Scene samescene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(samescene.buildIndex);
        
    }
    private void lobby ()
    {
        SceneManager.LoadScene(0);
    }
}
