﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_MovementTest : MonoBehaviour {

    public float fl_SpeedH;
    public float fl_SpeedV;

    public float yRotation = 5.0F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Control();

        print(transform.eulerAngles.y);
	}

    void Control()
    {
        float transV = Input.GetAxis("Vertical") * fl_SpeedV;
        float transH = Input.GetAxis("Horizontal") * fl_SpeedH;
        transV *= Time.deltaTime;
        transH *= Time.deltaTime;
        transform.Translate(0, 0, transV);
        transform.Translate(transH, 0, 0);

        yRotation = Input.GetAxis("LeftHor");
        transform.eulerAngles = new Vector3(0, yRotation, 0);


    }
}