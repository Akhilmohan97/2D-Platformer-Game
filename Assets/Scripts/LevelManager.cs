using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instinct;
    public static LevelManager Instinct;
    private void Awake()
    {
        if (instinct == null)
        {
            instinct = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public LevelStatus Getlevelstatus (ref string level)
    {
        Debug.Log("Get level status");
      LevelStatus levelStatus1 =(LevelStatus) PlayerPrefs.GetInt(level, 0);
        return LevelStatus.Locked;
    }
    //public LevelStatus GetLevelStatus { set { PlayerPrefs.SetInt(value, (int)levelStatus); } }
    public void Setlevelstatus (string level ,LevelStatus levelStatus)
    {
        PlayerPrefs.SetInt(level, (int) levelStatus);
    }
}
