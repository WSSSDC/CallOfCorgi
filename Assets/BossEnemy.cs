using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnemy : MonoBehaviour
{
    public int health = 100;

   
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();

            Invoke("SceneManager.LoadScene(0)", 3);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
