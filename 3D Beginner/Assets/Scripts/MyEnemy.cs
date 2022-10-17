using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public GameEnding gameEnding;
    [SerializeField] private int health;
    public void Hurt(int damage)
    {
        Debug.Log("Hit: " + damage);
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
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
