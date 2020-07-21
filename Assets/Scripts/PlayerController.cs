using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jump;
    public string SameLevel;
    public ScoreController scoreController;
    public Gameover gameover;
    public GameObject heart1, heart2, heart3;
    private int health = 3;


    

    

    

   private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
       
        playerMovement(horizontal,vertical);
        playerAnimation(horizontal,vertical);
        LevelEndScript();


        

    }

   
    void playerMovement(float horizontal,float vertical)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
      
        transform.position=  position;
       


    }
    void playerAnimation(float horizontal,float vertical)
    {
        Vector3 scal = transform.localScale;
        if (horizontal == 1)
        {
            scal.x = 2;
            animator.SetBool("speed greater", true);
            transform.localScale = scal;
            

        }
        else if (horizontal < 0)
        {
            scal.x = -2;

            animator.SetBool("speed greater", true);

            transform.localScale = scal;
        }
        else
        {
            animator.SetBool("speed greater", false);
        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouch", true);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(.05f, 0.65f);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.5f, 1.37f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouch", false);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(.02f, 0.97f);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0.6f, 2.02f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("stayfunction1");

        if (collision.gameObject.tag == "Ground")
        {

            Debug.Log("stayfunction");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
               

            }
        }
    }

   
    void LevelEndScript ()
    {
        if (gameObject.transform.position.y < -12.8f)
        {
           gameover.ReloadScene();
        }
    }
    public void pickup()
    {
        Debug.Log("pickup player controller");
        scoreController.IncreaseScore(10);

        


    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>() != null)
        {
            animator.SetBool("Death", true);
            StartCoroutine(MyCoroutine());
        }
    }
    IEnumerator MyCoroutine()
    {
        Debug.Log("delay");
        yield return new WaitForSeconds(1f);
        healthScript();







    }
    void healthScript()
    {
        health = health - 1;
        switch (health)
        {
            case 3:
                Debug.Log("3");
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true);
                break;

            case 2:
                Debug.Log("2");
                transform.position = new Vector3(0, 0, 0);
                animator.SetBool("Death", false);
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);

                break;
            case 1:
                Debug.Log("1");
                transform.position = new Vector3(0, 0, 0);
                animator.SetBool("Death", false);
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);

                break;
            case 0:
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                gameover.ReloadScene();
                break;
        }

    }




}
      

             

