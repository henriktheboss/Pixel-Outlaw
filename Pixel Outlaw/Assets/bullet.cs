using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float Speed = 20f;
    public float Leftspeed = -20f;
    public Rigidbody2D rb;
    public int damage = 50;

    void Start()
    {
        rb.velocity = transform.right * Speed;



    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hitinfo.gameObject.CompareTag("Enemy"))
            {

            EnemtHealth enemy = hitinfo.GetComponent<EnemtHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);
            }
    }

  
}
