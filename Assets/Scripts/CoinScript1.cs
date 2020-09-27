using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript1 : MonoBehaviour {
    public Rigidbody myBody;
    public float bounceForce = 0.1f;
    public PoolScript1 poolScript1;
    public bool coinsIn2 = false;
    public bool coinsGone2 = false;
    public CheckPointScript1 checkPointScript1;
    public static CoinScript1 instance;

    void Awake() {
        instance = this;
    }
    void Start() {
        coinsIn2 = false;
    }

    void FixedUpdate() {
        if (checkPointScript1.inCheckPoint2 == true) {
            //myBody.AddForce(0,0,bounceForce*Time.deltaTime);

            coinsIn2 = true;

            if (coinsIn2 == true) {
                Invoke("CoinDisable", 3f);

            }
        }

    }
    void CoinDisable() {
        Destroy(gameObject);
        coinsGone2 = true;
    }


}//end class
