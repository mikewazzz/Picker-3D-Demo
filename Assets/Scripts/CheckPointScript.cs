using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointScript : MonoBehaviour {
    public bool inCheckPoint = false;
    public PlayerMovementScript playerMovementScript;
    public PoolScript poolScript;
    public static CheckPointScript instance;
    void Awake() {
        instance = this;
    }

    void OnTriggerEnter(Collider target) {

        if ( target.tag == "Player") {
            inCheckPoint = true;
            playerMovementScript.enabled = false;
        }

    }

}//end class
