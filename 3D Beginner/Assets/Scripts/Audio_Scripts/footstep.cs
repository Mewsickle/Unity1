
using UnityEngine;

[RequireComponent(typeof(AudioSource))]


public class footstep : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] AudioClip[] audioClip;
    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    //animation event
    private void Step()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
        

    }

    private AudioClip GetRandomClip()
    {
        int index = Random.Range(0, audioClip.Length - 1);
        return audioClip[index];
    }
}
