using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    [SerializeField] private LayerMask _mask;
    [SerializeField] private Transform _player;
    bool seePlayer;
    


    int m_CurrentWaypointIndex;

    void Start ()
    {
        navMeshAgent.SetDestination (waypoints[0].position);
    }

    void Update ()
    {
       
    }


    private void FixedUpdate()
    {
        RaycastHit hit;
        var startPos = transform.position;
        var dir = _player.position - startPos;
        var rayCast = Physics.Raycast(startPos, dir, out hit, 6f, _mask);

        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance && !seePlayer)
        {

            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            
        }
        


        if (rayCast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                seePlayer = true;
                Debug.Log("SEE");
                navMeshAgent.SetDestination(_player.position);
            }
            else
            {
                seePlayer = false;
                Debug.Log("CANT SEE");
            }
            
        }
       
    }
}
