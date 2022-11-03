using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTriggerScript : MonoBehaviour
{
    [SerializeField] GameObject trapToSpawn;
    [SerializeField] GameObject doorToOpen;
    [SerializeField] AudioSource trapSoundTrigger;
    [SerializeField] AudioSource trapSoundRolling;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(trapToSpawn, new Vector3(112.27f, 6.43f, 45.46f), Quaternion.identity);
            //trapSoundTrigger = GetComponent<AudioSource>();
            trapSoundTrigger.Play(0);
            trapSoundRolling.Play(4);
            Destroy(gameObject);
            doorToOpen.transform.Translate(29.26f, 8.17f, -11.35f);
            
        }
    }
}
