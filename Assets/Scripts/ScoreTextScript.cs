using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour {

    public Text textScore;
    public GameObject checkPointFailedUI;
    public GameObject awesomeUI;
    public ScoreTextScript scoreTextScript;

    public static int coinAmount;
    public CoinScript coinScript;
    public CoinScript1 coinScript1;

    void Start() {
        textScore = GetComponent<Text>();
    }


    void Update() {

        textScore.text = coinAmount.ToString();

        if (ScoreTextScript.coinAmount >= 15) {

            awesomeUI.SetActive(true);
        }
        if (coinScript.coinsGone == true && ScoreTextScript.coinAmount < 15) { //if check point failed play UI and restart LEVEL 1

            checkPointFailedUI.SetActive(true);

            Invoke("ReloadScene", 3f);  //RESTART level 1 
        }


        //********************** 2. checkpoint scoring and UI*******************************

        if (ScoreTextScript.coinAmount >= 25) {

            awesomeUI.SetActive(true);
        }
        if (coinScript1.coinsGone2 == true && ScoreTextScript.coinAmount < 25) {

            checkPointFailedUI.SetActive(true);

            Invoke("ReloadScene", 3f); //RESTAR level1 

        }


    }
    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //if checkpoint failed reload LEVEL 1
        //++add reset score
    }



}

