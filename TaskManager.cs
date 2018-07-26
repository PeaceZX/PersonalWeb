using UnityEngine;
using System.Collections;
using System;
//UI iamge, Text
using UnityEngine.UI;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour
{

    public Image ImageTask;


    void Start()
    {
        ImageTask.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // 碰撞开始
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "NPC")
        {
            ImageTask.enabled = true;

        }


    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            ImageTask.enabled = false;

        }
    }
    

    }