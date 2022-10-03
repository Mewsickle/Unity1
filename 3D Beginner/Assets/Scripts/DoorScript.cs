using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private Transform _player;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == _player)
            Debug.Log("in range");
            
            Destroy(gameObject);
          
    }
}
