using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.tag == "Player") 
        { 
        cam2.enabled = true;
        cam1.enabled = false;
        }
        
    }

}
