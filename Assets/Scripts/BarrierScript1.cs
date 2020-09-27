using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript1 : MonoBehaviour {
    public PoolScript1 poolScript1;
    public Animator animator;
    public CheckPointScript1 checkPointScript1;
    public PlayerMovementScript playerMovement;

    void Start() {

        animator = GetComponent<Animator>();
    }

    void FixedUpdate() {

        if (poolScript1.pool2IsUp == true) { //if level passed open barrier and make player movement on

            animator.Play("BarrierAnimation");
            Invoke("NotInCheckPoint", 2f);
        }
    }

    void NotInCheckPoint() {

        CheckPointScript1.instance.inCheckPoint2 = false;
        // barrier2 open, incheckpoint2 false, movement on at (at barrierscript)
    }

}
