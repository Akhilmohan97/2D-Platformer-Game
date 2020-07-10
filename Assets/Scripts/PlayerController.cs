using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
   private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        playerHorizontal(horizontal);
        playerAnimation(horizontal);

       
        

    }
    void playerHorizontal(float horizontal)
    {
        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        Debug.Log("x");
        transform.position=  position;
    }
    void playerAnimation(float horizontal)
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
        float jum = Input.GetAxisRaw("Vertical");
        if (jum > 0)
        {
            animator.SetBool("jump", true);
        }

        else
        {
            animator.SetBool("jump", false);
        }
    }

}
      

             

