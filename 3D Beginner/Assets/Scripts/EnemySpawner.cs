using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool m_IsPlayerInRange;
    
    [SerializeField] private Transform _launchpoint;
    [SerializeField] private Transform _player;
    [SerializeField] GameObject _enemyToSpawn;
    [SerializeField] private float _cooldownTime = 5f;
    public float _enemyCount = 0f;
    private float nextSpawnTime = 0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == _player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == _player)
        {
            m_IsPlayerInRange = false;
        }
    }
    public void Counter()
    {
       _enemyCount--;
    }
    private void Update()
    {

        if (m_IsPlayerInRange && _enemyCount <= 2)
        {


            if (Time.time > nextSpawnTime)
            {

                GameObject enemy = Instantiate(_enemyToSpawn, _launchpoint.position, _launchpoint.rotation);
                nextSpawnTime = Time.time + _cooldownTime;
                _enemyCount++;
            }
        }
    }
   
}

                
                


       

