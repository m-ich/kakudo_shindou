using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update

	public Text inputtext1, inputtext2;
    float x_l,y_l,z_l,x_r,y_r,z_r; //コントローラー左右の座標
    float wa_x_l, wa_y_l, wa_z_l;//ワールド座標回転角度
    float wa_x_r, wa_y_r, wa_z_r; 
    float la_x_l, la_y_l, la_z_l;//ローカル座標回転角度
    float la_x_r, la_y_r, la_z_r;

    public OVRInput.Controller controller;

    void Start()
    {
        controller = GetComponent<OVRControllerHelper>().m_controller;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == OVRInput.Controller.LTouch)
        {
            //Instantiate(sphere, transform.position, transform.rotation);
            Vector3 position = transform.position;
            Vector3 worldAngle = transform.eulerAngles;
            Vector3 localAngle = transform.localEulerAngles;
            x_l = position.x;
            y_l = position.y;
            z_l = position.z;
            wa_x_l = worldAngle.x;
            wa_y_l = worldAngle.y;
            wa_z_l = worldAngle.z;
            la_x_l = localAngle.x;
            la_y_l = localAngle.y;
            la_z_l = localAngle.z;
            inputtext1.text = "<Left>\n" +
                "position x:" + x_l.ToString() + " y:" + y_l.ToString()+" z:" + z_l.ToString()+
                "\nWorld Angle x:" + wa_x_l.ToString() + " y:" + wa_y_l.ToString() + " z:" + wa_z_l.ToString()+
                "\nLocal Angle x:" + la_x_l.ToString() + " y:" + la_y_l.ToString() + " z:" + la_z_l.ToString();
        } else if (controller == OVRInput.Controller.RTouch)
        {
            Vector3 position = transform.position;
            Vector3 worldAngle = transform.eulerAngles;
            Vector3 localAngle = transform.localEulerAngles;
            x_r = position.x;
            y_r = position.y;
            z_r = position.z;
            wa_x_r = worldAngle.x;
            wa_y_r = worldAngle.y;
            wa_z_r = worldAngle.z;
            la_x_r = localAngle.x;
            la_y_r = localAngle.y;
            la_z_r = localAngle.z;
            inputtext2.text = "<Right>\n" +
                "position x:" + x_r.ToString() + " y:" + y_r.ToString() + " z:" + z_r.ToString()+
                "\nWorld Angle x:" + wa_x_r.ToString() + " y:" + wa_y_r.ToString() + " z:" + wa_z_r.ToString()+
                "\nLocal Angle x:" + la_x_r.ToString() + " y:" + la_y_r.ToString() + " z:" + la_z_r.ToString();
        } else{
            inputtext1.text = "Null";
            inputtext2.text = "Null";
        }
    }
}
