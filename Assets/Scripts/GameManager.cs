using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Image[] handles;
    public GameObject LevelCompleteUI;
    public GameObject Level2UI;
    public PoolScript poolScript;
    public PoolScript1 poolScript1;
    void Start() {
        if (handles.Length > 0) {
            handles[0].color = Color.red;// 1.checkpointte red progressbar
        }
    }

    void Update() {
        if (poolScript.poolIsUp == true) {
            if (handles.Length > 0) {
                handles[1].color = Color.red; // 1.checkpoint passed 2. progressbar red
            }

        }
        if (poolScript1.pool2IsUp == true) {
            if (handles.Length > 0) {
                handles[2].color = Color.red; // 1.checkpoint passed 3. progressbar red
            }
        }
    }
    public void ChangeLevel() {

        Level2UI.SetActive(true);
        Debug.Log(" LEVEL 2 UI!");
    }

    public void CompleteLevel() {

        LevelCompleteUI.SetActive(true);
        Debug.Log(" LEVEL complete!");
    }

}//end class

