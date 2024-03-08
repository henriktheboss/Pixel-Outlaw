using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camra : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; 
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 desierdPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desierdPos, speed * Time.deltaTime);
    }
}
