using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementScript : MonoBehaviour
{

    public Rigidbody myBody;
    public float forwardForce=150f;
    public float sideForces = 200f;
    
    void FixedUpdate()
    {
        myBody.AddForce(0, 0, forwardForce *Time.deltaTime);// forward force

        if (Input.GetKey(KeyCode.RightArrow)){
            myBody.AddForce(sideForces*Time.deltaTime , 0,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            myBody.AddForce(-sideForces * Time.deltaTime, 0, 0);
        }


    }

}//end class
