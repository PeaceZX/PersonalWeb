using UnityEngine;
using System.Collections;
using System;
//UI iamge, Text
using UnityEngine.UI;
using System.Collections.Generic;

public class StoryLine : MonoBehaviour
{

    public Image storyline;

    void Start()
    {
        storyline.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // 碰撞开始
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Entrance")
        {
            storyline.enabled = true;

        }


    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Entrance")
        {
            storyline.enabled = false;

        }
    }


}