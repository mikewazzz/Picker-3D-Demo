using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTriggerScript : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter() {
        gameManager.ChangeLevel(); //Level 2 UI displays
        Invoke("LoadNextScene", 4f);
    
    }

    public void LoadNextScene() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Load Next Scene Level 2
    }

}//end class
