using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelEndScript : MonoBehaviour
{
    public string scene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if  (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            SceneManager.LoadScene(scene);
        }
    }

}
