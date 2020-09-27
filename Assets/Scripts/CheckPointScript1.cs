using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointScript1 : MonoBehaviour {
    public bool inCheckPoint2 = false;
    public PlayerMovementScript playerMovementScript;
    public PoolScript1 poolScript1;
    public PoolScript poolScript;
    public PlayerMovementScript playerMovement;
    public static CheckPointScript1 instance;
    public bool isMoving = true;

    void Awake() {

        instance = this;
    }
    
   public  void OnTriggerEnter(Collider target) {

        if (target.tag == "Player") {
            inCheckPoint2 = true;
            isMoving = false;

        }
    }

}//end class
