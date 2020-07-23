using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectLobby : MonoBehaviour
{
    public Button Level1, Level2;
      string levela;
  string levelb;
    private void Awake()
    {
       // Level1.onClick.AddListener(level1load);
        //Level2.onClick.AddListener(level2load);
    }
    public void level1load()
    {
        Debug.Log("Level1Load");
         LevelStatus levelStatus = LevelManager.Instinct.Getlevelstatus(ref levela);
        // if (levelStatus != null)
        // {
       // LevelStatus levelStatus = LevelStatus.Locked;
            switch (levelStatus)
            {
                case LevelStatus.Locked:
                    Debug.Log("Cant play the level its locked");
                    break;
                case LevelStatus.Ulocked:
                    SceneManager.LoadScene(1);
                    break;
                case LevelStatus.Completed:
                    SceneManager.LoadScene(1);
                    break;


            }
      //  }
           
       
    }
    public void level2load()
    {
        LevelStatus levelStatus = LevelManager.Instinct.Getlevelstatus(ref levelb);
        switch (levelStatus)
        {
            case LevelStatus.Locked:
                Debug.Log("Cant play the level its locked");
                break;
            case LevelStatus.Ulocked:
                SceneManager.LoadScene(2);
                break;
            case LevelStatus.Completed:
                SceneManager.LoadScene(2);
                break;


        }
       
    }
}
