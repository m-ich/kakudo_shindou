using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vector_controller : MonoBehaviour
{
    public Transform front_left, back_left;
    public Transform front_right, back_right;

    public Text kakudo_text1, kakudo_text2, kakudo_real;

    public OVRInput.Controller controller;

    public Vector3 ver_left, ver_right;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<OVRControllerHelper>().m_controller;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == OVRInput.Controller.LTouch) {
            //ver_left = front_left.position - back_left.position;
            ver_left = (front_left.position - back_left.position).normalized;
            ver_left.y = 0;
            kakudo_text1.text = "<Left> : "+ ver_left.ToString("F4");
        } else if (controller == OVRInput.Controller.RTouch) {
            //ver_right = front_right.position - back_right.position;
            ver_right = (front_right.position - back_right.position).normalized;
            ver_right.y = 0;
            kakudo_text2.text = "<Right> : " + ver_right.ToString("F4");
        } else {
            kakudo_text1.text = "Null";
            kakudo_text1.text = "Null";
        }
        //float angle = Vector3.Angle(ver_left, transform.forward);
        //float angle = Vector3.Angle(ver_left,ver_right);
        //kakudo_real.text = "<Angle> : " + angle.ToString();
    }
}
