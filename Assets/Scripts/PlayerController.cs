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
        
    }
    
}
