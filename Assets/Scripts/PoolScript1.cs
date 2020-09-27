using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript1 : MonoBehaviour {

    public static PoolScript1 instance;
    private CoinScript1 coinScript1;
    private Animator anim;
    public PlayerMovementScript playerMovement;
    public bool pool2IsUp = false;


    void Awake() {
        instance = this;
    }

    void Start() {
        anim = GetComponent<Animator>();
        coinScript1 = GetComponent<CoinScript1>();

    }

    void OnTriggerEnter(Collider other) {

        ScoreTextScript.coinAmount++;

    }

    void FixedUpdate() {

        if (CoinScript1.instance.coinsGone2 == true) { //coins in and disappeared
            if (ScoreTextScript.coinAmount >= 15) { //check if coin skore are 15+

                Invoke("PoolAnim", 1f);
                pool2IsUp = true;

            } else {
                pool2IsUp = false;
            }
        }
    }
    void PoolAnim() {

        anim.Play("Pool2Animation");

    }

}//end class

