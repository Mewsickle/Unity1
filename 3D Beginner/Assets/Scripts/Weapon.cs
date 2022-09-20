using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject mine;
    [SerializeField] private Transform _mineSpawnPosition;
    [SerializeField] bool mineOn;
    [SerializeField] float cooldownTime;
    private float nextFireTime = 0;



    void Start()
    {
        mineOn = false;

    }

    void Update()
    {
      if(Time.time > nextFireTime)
        {

            if (Input.GetButtonDown("Fire1"))
            {
                if (!mineOn)
                {
                    Debug.Log("No Weapon");
                }
                else if (mineOn = true)
                {
                    Instantiate(mine, _mineSpawnPosition.position, _mineSpawnPosition.rotation);
                    nextFireTime = Time.time + cooldownTime;
                }

            }
        }
      


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Power"))
        {
            mineOn = true;
        }
    }
}
