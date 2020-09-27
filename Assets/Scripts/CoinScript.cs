using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public Rigidbody myBody;
    public float bounceForce = 0.1f;
    public PoolScript poolScript;
    public bool coinsIn = false;
    public bool coinsGone = false;
    public CheckPointScript checkPointScript;
    public static CoinScript instance;

    void Awake() {
        instance = this;
    }
    void Start() {

        coinsIn = false;
    }
    void FixedUpdate() {

        if (checkPointScript.inCheckPoint == true) {
            coinsIn = true;

            if (coinsIn == true) {
                Invoke("CoinDisable", 3f);
            }
        }
    }
    void CoinDisable() {
        Destroy(gameObject);
        coinsGone = true;
    }

}//end class
