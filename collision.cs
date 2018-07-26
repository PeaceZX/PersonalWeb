using UnityEngine;
using System.Collections;
using System;

public class collision : MonoBehaviour
{

    public int scoreValue;
    private RigidBodyFPSController rigidBodyFPSController;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    // 碰撞开始
    void OnCollisionEnter(Collision collision)
    {
        
            Destroy(this.gameObject);
        

    }


}