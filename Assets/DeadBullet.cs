using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.tag == "Player")
        {
            hitInfo.transform.position = new Vector3(242.57f, -6.82f, 0f);
            Destroy(gameObject);
        }
        if(hitInfo.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        
    }
 
}
