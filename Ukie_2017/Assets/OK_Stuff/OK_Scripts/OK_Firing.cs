using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_Firing : MonoBehaviour {

    public GameObject GO_bullet;

    public float fl_trigger;

    void Start()
    {
        fl_trigger = Input.GetAxis("Right_Trigger");

    }
    
    void Update()
    {
        Fire();

    }//---

    void Fire()
    {
        if (Input.GetAxis("Right_Trigger") < 0)
         
        {
            Instantiate(GO_bullet, transform.position + transform.TransformDirection(new Vector3(0, 0, 2F)), transform.rotation);

        }

    }//---
}
 