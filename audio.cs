
using UnityEngine;
using System.Collections;
using System;
//UI iamge, Text
using UnityEngine.UI;
using System.Collections.Generic;

public class audio : MonoBehaviour
{
    //audio effect on collision
    public AudioSource audioSource;
    //audio clip
    public AudioClip audioCorrect;
    public AudioClip audioEndword;
    public AudioClip happiness;
    public AudioClip welcomeword;
    //particle effect on collision
    public ParticleSystem myParticleSystem;
    //completed task showing image
    public Image image;
    public Image storyline;
    //score board
    public Text text;
    public int count;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        myParticleSystem = GetComponent<ParticleSystem>();
        count = 0;
        //no image shown
        image.enabled = false;
        storyline.enabled = false;
    }
    void endimage()
    {
        if(count == 6)
        {
            //pop up image after task complete
            image.enabled = true;
        }
    }
    void endword()
    {
        if (count == 6)
        {
            audioSource.PlayOneShot(audioEndword);
            audioSource.PlayOneShot(happiness);
            //soundTimer = FlightWind.length;
        }
    }
    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + count; 
        //RigidBodyFPSController.GetComponent<Text>().text = count.ToString("");
    }

    // 碰撞开始
    void OnCollisionEnter(Collision collision)
    {
        //count++; 
        if (collision.gameObject.tag == "Task")
        {
            audioSource.PlayOneShot(audioCorrect);
            myParticleSystem.Play();
            count++;
            endword();
            endimage();
        }
        if (collision.gameObject.tag == "Entrance")
        {
            audioSource.PlayOneShot(welcomeword);
            //AudioClip.DestroyImmediate(happiness);
            storyline.enabled = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Entrance")
        {
            storyline.enabled = false;
            audioSource.Stop();
        }
    }
}