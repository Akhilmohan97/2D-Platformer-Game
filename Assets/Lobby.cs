using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    public Button button;
    public GameObject levelselector;
    private void Start()
    {
        button.onClick.AddListener(StartScene);
    }
    void StartScene()
    {
        levelselector.SetActive(true);
    }
}
