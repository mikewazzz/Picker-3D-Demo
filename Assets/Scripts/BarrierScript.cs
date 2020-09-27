using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour {
    public PoolScript poolScript;
    public PoolScript1 poolScript1;
    public Animator animator;
    public PlayerMovementScript playerMovement;
    public CheckPointScript1 checkPointScript1;
    
    void Start() {

        animator = GetComponent<Animator>();
    }

    void FixedUpdate() {
        if (poolScript.poolIsUp == true) { //if level passed open barrier and make player movement on

            animator.Play("BarrierAnimation");
            Invoke("PlayerMovementOn", 3f);

            //if pool1 up player can move but if at checkpoint2 player stops
            if (poolScript.poolIsUp == true && checkPointScript1.inCheckPoint2 == true) {
                playerMovement.enabled = false; //stop movement
            }
        }
    }

    void PlayerMovementOn() {
        playerMovement.enabled = true;
    }
}
