using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter(Collider other) {

        gameManager.CompleteLevel();
        Invoke("ReloadScene", 3f);
    }

    public void ReloadScene() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //if check failed reload lvl1
    }
}




