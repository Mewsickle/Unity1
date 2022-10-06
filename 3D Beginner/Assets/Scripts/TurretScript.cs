using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class NewBehaviourScript : MonoBehaviour
//{
//    [SerializeField] private Transform _target;
//    //private void Update()
//    //{
//    //    transform.LookAt(_target);
//    //}
//    private void OnTriggerEnter(Collider other)
//    {

//        if (other.gameObject.CompareTag("Player"))
//        {
//            transform.LookAt(_target);

//        }
//    }
//}

public class TurretScript : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform launchPoint;
    [SerializeField] GameEnding gameEnding;
    [SerializeField] private Transform target;
    [SerializeField] GameObject fireball;
    [SerializeField] float launchVelocity;
    [SerializeField] float cooldownTime;
    private float nextFireTime = 1;

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
        

        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            //Vector3 direction = target.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;
            
            

                if (Time.time > nextFireTime)
                {
                    //this.transform.rotation = Quaternion.LookRotation(direction, Vector3.up);

                    GameObject ball = Instantiate(fireball, launchPoint.position, launchPoint.rotation);
                    ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, launchVelocity, 0));
                    Destroy(ball, 2.0f);
                    nextFireTime = Time.time + cooldownTime;

                }
            
        }
    }
}
