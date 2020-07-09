using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        Vector3 scal = transform.localScale;
       // boxCollider = gameObject.GetComponent<Collider2D>();
        if (speed == 1)
        {
            scal.x = 2;
            animator.SetBool("speed greater", true);
            transform.localScale = scal;
           
        }
       else if (speed < 0)
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
        if (jum >0)
        {
            animator.SetBool("jump", true);
        }

        else
        {
            animator.SetBool("jump", false);
        }
        
    }
             
}
