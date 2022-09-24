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
    [SerializeField] GameEnding gameEnding;
    [SerializeField] private Transform _target;
    [SerializeField] GameObject fireball;

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
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    transform.LookAt(_target);
                    Instantiate(fireball, new Vector3(112.27f, 6.43f, 45.46f), Quaternion.identity);

                }
            }
        }
    }
}
