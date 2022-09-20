using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class MineScript : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float delay;

    private void Start()
    {
        Destroy(gameObject, delay);
    }
   

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Enemy"))
        {
            MyEnemy enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);
            Destroy(gameObject);
        }
    }
    
}
