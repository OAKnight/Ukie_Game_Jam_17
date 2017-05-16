using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OK_MovementTest : MonoBehaviour {

    
    public float fl_SpeedH;
    public float fl_SpeedV;

	// Update is called once per frame
	void Update () {
        Control();
	}

    void Control()
    {
        
        // Left analog controls to move the PC within the space
        float transV = Input.GetAxis("Vertical") * fl_SpeedV;
        float transH = Input.GetAxis("Horizontal") * fl_SpeedH;
        transV *= Time.deltaTime;
        transH *= Time.deltaTime;
        transform.position += new Vector3(0, 0, transV);
        transform.position += new Vector3(transH, 0, 0);

        // Right analog stick, this is used to control the player facing.
        float fl_rightx = Input.GetAxis("Right_Hor");
        float fl_righty = Input.GetAxis("Right_Vert");

        float fl_angler = Mathf.Atan2(fl_rightx, fl_righty);

        transform.rotation = Quaternion.EulerAngles(0, fl_angler, 0);
 



    }
}
