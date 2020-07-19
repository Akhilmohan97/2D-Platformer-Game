using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

  public   PlayerController playerController;
    public Animator animator;




    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() != null)
            {
            animator.SetBool("Death", true);
            StartCoroutine(MyCoroutine());
           
         


            }
    }
    IEnumerator MyCoroutine()
    {
        Debug.Log("delay");
        yield return new WaitForSeconds(3f);
        playerController.ReloadScene();


    }



}
