using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jump;
   private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
        
        playerMovement(horizontal,vertical);
        playerAnimation(horizontal,vertical);

       
        

    }
    void playerMovement(float horizontal,float vertical)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        Debug.Log("x");
        transform.position=  position;
        if (vertical >0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump),ForceMode2D.Force);
        }
    }
    void playerAnimation(float horizontal,float vertical)
    {
        Vector3 scal = transform.localScale;
        if (horizontal == 1)
        {
            scal.x = 2;
            animator.SetBool("speed greater", true);
            transform.localScale = scal;
            Debug.Log("y");

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
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("crouch", false);
        }
        if(vertical >0)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
    }

}
      

             

