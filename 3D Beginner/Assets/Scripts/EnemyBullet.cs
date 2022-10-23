using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] GameObject playerDamage;




    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            HealthUI player = playerDamage.GetComponent<HealthUI>();
            player.Hurt(_damage);
            Destroy(gameObject);
        }
    }
}
