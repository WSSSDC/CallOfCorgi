using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
       

        if (enemy != null)
        {
            enemy.TakeDamage(33);
            Destroy(gameObject);
        }
        if(hitInfo.tag == "Obstacle")
        {
            Destroy(gameObject);
        }

    }

}
