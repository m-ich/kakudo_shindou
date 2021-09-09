using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angle_controller : MonoBehaviour
{
    //public Vector3 ver_left, ver_right;
    public Text kakudo_real;
    public Vector_controller vector_Controller, vector_Controller2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vector_Controller.ver_left!=null && vector_Controller2.ver_right != null) {
            Vector3 ver_left = vector_Controller.ver_left;
            Vector3 ver_right = vector_Controller2.ver_right;
            float angle = Vector3.Angle(ver_left, ver_right);
            kakudo_real.text = "<Angle> : " + angle.ToString();
            if (angle>=40)
            {
                OVRInput.SetControllerVibration(1f, 1f);
            } else if (angle<40)
            {
                OVRInput.SetControllerVibration(0, 0);
            } else {
                OVRInput.SetControllerVibration(0, 0);
            }
        } else { }
    }
}
