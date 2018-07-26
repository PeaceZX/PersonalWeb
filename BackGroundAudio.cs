using UnityEngine;
using System.Collections;
using System;
//UI iamge, Text
using UnityEngine.UI;
using System.Collections.Generic;

public class BackGroundAudio : MonoBehaviour {

    public AudioClip welcomeword;
    public AudioClip happiness;
    public AudioSource audioSource2;

    // Use this for initialization
    void Start () {
       audioSource2 = GetComponent<AudioSource>();
        audioSource2.PlayOneShot(happiness);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "entrance")
        { 
            audioSource2.PlayOneShot(welcomeword);
            Destroy(happiness);
        }
       
    }
}
