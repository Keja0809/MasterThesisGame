using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseDialogue : MonoBehaviour
{ 

    public CameraLook cameraScript;


    public static bool GameIsPaused = false;
    // Update is called once per frame


    public void Resume()
    {
        Time.timeScale = 1;
        cameraScript.enabled = true;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        cameraScript.enabled = false;
    }

 


}
