using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   // ScoreController ScoreController;
    public PlayerController playerController;

    
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       if (collision.gameObject.GetComponent<PlayerController>()!=null)
        {
            playerController = collision.gameObject.GetComponent<PlayerController>();

               playerController.pickup ();
           
                 Destroy(gameObject);
          


        }
    }
}
