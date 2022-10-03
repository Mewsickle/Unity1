using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject mine;
    //[SerializeField] private GameObject _powerUp2;
    [SerializeField] GameObject _projectile;
    [SerializeField] private float _velocity = 200f;
    [SerializeField] private float _cooldownTime2 = 3f;
    [SerializeField] private Transform _mineSpawnPosition;
    [SerializeField] private Transform _launchpoint;

    bool mineOn;
    bool shootOn;

    [SerializeField] float cooldownTime1;
    private float nextFireTime = 0;



    void Start()
    {
        mineOn = false;
        shootOn = false; 
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
                    nextFireTime = Time.time + cooldownTime1;
                }

            }

            else if (Input.GetButtonDown("Fire2"))
            {
                if(!shootOn)
                {
                    Debug.Log("No Shooty stuff");
                }

                else if (shootOn = true)
                {
                    GameObject bullet = Instantiate(_projectile, _launchpoint.position, _launchpoint.rotation);
                    bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, _velocity, 0));
                    nextFireTime = Time.time + _cooldownTime2;
                    Destroy(bullet, 2f);
                }
            }
        }
      


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Power"))
        {
            mineOn = true;
            shootOn = true;
        }
        //else if (other.gameObject.CompareTag("Door"))
        //{

        //}
    }
}
