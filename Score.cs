using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Score : MonoBehaviour
{
    //public Transform RigidBodyFPSController;
    public GameObject RigidBodyFPSController;
    public Text text;
    //private object count;
    public int scoree;

    //public float score;
    //public int count;
    void Start()
    {
        RigidBodyFPSController.GetComponent<audio>().count = scoree;
    }
    // Update is called once per frame
    void Update()
    {
        //text.text = other.count.ToString();

        //Debug.Log(RigidBodyFPSController.position.z);
        //RigidBodyFPSController.GetComponent<audio>().count = scoree;
        text.text = "score:" + scoree;

    }
}
