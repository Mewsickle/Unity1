using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript1 : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _defaultTarget;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _launchpoint;
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _velocity = 200f;
    [SerializeField] private float _cooldownTime = 3f;
    [SerializeField] GameObject _projectile;
    private float nextFireTime = 0;






    bool m_IsPlayerInRange;
    
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
    private void Update()
    {
        float angle = Quaternion.Angle(transform.rotation, _target.rotation);
        //print(angle); 
        
        if (m_IsPlayerInRange && angle <= 100)
        {
           
                Vector3 targetDir = _target.position - transform.position;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, _speed * Time.deltaTime, 0.0F);

                transform.rotation = Quaternion.LookRotation(newDir);
            if (Time.time > nextFireTime)
            { 
               
                GameObject ball = Instantiate(_projectile, _launchpoint.position, _launchpoint.rotation);
                ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, _velocity, 0));
                nextFireTime = Time.time + _cooldownTime;
                Destroy(ball, 2f);
            }

        }
        else
        {
            Vector3 defaultDir = _defaultTarget.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, defaultDir, _speed * 2 * Time.deltaTime, 0.0F);

            transform.rotation = Quaternion.LookRotation(newDir);


        }
        
    }

}
