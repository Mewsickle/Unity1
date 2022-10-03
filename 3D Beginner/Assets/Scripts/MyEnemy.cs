using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public GameEnding gameEnding;
    [SerializeField] private int health;
    [SerializeField] bool isSeeker = false;
    public void Hurt(int damage)
    {
        Debug.Log("Hit: " + damage);
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        if (isSeeker = true)
        {
            Debug.Log("dead");

            //EnemySpawner count = GetComponent<EnemySpawner>();
            //count.Counter();

        }

        Destroy(gameObject);
       


    }
   
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                gameEnding.CaughtPlayer();
            }
        }
    
}
