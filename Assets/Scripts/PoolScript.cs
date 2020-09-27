using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript : MonoBehaviour {

    public static PoolScript instance;
    public CoinScript coinScript;
    private Animator anim;
    public bool poolIsUp = false;

    void Awake() {

        instance = this;
    }

    void Start() {

        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other) {

        ScoreTextScript.coinAmount++;//score UI++
     
    }
    void FixedUpdate() {

        if (CoinScript.instance.coinsGone == true) { //if coins in and disappeared
            if (ScoreTextScript.coinAmount >= 15) { //check if coin score are 15+

                Invoke("PoolAnim", 1f);
                poolIsUp = true;

            } else {
                poolIsUp = false;
            }
        }
    }

    void PoolAnim() {

        anim.Play("PoolUpAnimation");
    }


}//end class

