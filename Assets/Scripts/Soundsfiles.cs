using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsfiles : MonoBehaviour
{
    public AudioClip triggerSound; //this is defining an AudioClip and naming it triggerSound
    AudioSource audioSource; //this is defining the audioSource and naming it audioSource

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollision2D(Collider2D other)
    {
        if(triggerSound != null)
        {
            audioSource.PlayOneShot(triggerSound, 0.7f);
        }
    }
}
