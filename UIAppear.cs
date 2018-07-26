using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour {

       public Image customImage;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "UIAppear")
        {
            customImage.enabled = true;
            
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "UIAppear")
        {
            customImage.enabled = false;
        }
    }



}
