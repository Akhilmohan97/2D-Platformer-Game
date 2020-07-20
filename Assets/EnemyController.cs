using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

  public   PlayerController playerController;
    public Animator animator;
    public float speedenemy;
    public Transform detector;
    bool moveright = true;
    public Gameover gameover;

    private void Update()  
    {
        transform.Translate(Vector2.right * speedenemy * Time.deltaTime);
        RaycastHit2D GroundDetect = Physics2D.Raycast(detector.position, Vector2.down , 3f);
        if(GroundDetect.collider == false)
        {
            if(moveright == true)
            {
                gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
                Debug.Log("ground");
                moveright = false;
            }
            else
            {
                gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                moveright = true;
            }
           
        }

    }


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
        gameover.ReloadScene();
    }



}
