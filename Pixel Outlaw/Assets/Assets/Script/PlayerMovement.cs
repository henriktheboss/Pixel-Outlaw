using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float Jump;
    private float move;
    public Rigidbody2D rb;
    public bool isJumping;
    public CoinManager cm;
    public bool facingLeft;
    public Animator anim;

     


    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));

        }

        if (move >= 1f || move <= -1f)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

       
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && !facingLeft)
        {
            transform.Rotate(0f, 180f, 0f);
            facingLeft = true;
        }

        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))&& facingLeft)
        {
            transform.Rotate(0f, 180f, 0f);
            facingLeft = false;
        }

        if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("isShooting", true);
        }
        else
        {
           anim.SetBool("isShooting", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isCrouching ", true);
        }
        else
        {
            anim.SetBool("isCrouching ", false);
        }

        if (isJumping)
        {
            anim.SetBool("Jumping", true);
        }

        if (!isJumping)
        {
            anim.SetBool("Jumping", false);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
           
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }

    

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            cm.coinCount++; 
        }
    }

   // private void OnCollisionStay2D(Collision2D other)
   // {
      //  if (other.gameObject.CompareTag("Floor"))
      //  {
           // anim.SetBool("isJumping", false);
     //   }
  //  }

   // private void OnCollisionExit2D(Collision other)
  //  {
       // if (other.gameObject.CompareTag("Floor"))
      //  {
       //     anim.SetBool("isJumping", true);
     //   }
   // }

}



