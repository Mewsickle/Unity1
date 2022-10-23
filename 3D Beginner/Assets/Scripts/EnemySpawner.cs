using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyToSpawn;
    [SerializeField] Transform player;
    [SerializeField] float cooldownTime;
    
    float enemyCount = 0f;
    float nextFireTime = 0f;
    bool m_IsPlayerInRange;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    void Update()
    {


        if (m_IsPlayerInRange && enemyCount <= 3 && Time.time > nextFireTime)
        {
            Instantiate(enemyToSpawn, transform.position, transform.rotation);
            nextFireTime = Time.time + cooldownTime;
            enemyCount++;
        }
    }
}