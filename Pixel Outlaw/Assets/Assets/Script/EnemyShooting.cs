using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject skud;
    public Transform bulletPos;
    private GameObject player;
    public float timeToShoot;


    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position);
  

        if (distance < 7 && enemyPatrol.inRange)
        {
            timer += Time.deltaTime;

            if (timer > timeToShoot)
            {
                timer = 0;
                shoot();
            }
        }

        
    }

     void shoot()
    {
        Instantiate(skud, bulletPos.position, Quaternion.identity);
    }
}
