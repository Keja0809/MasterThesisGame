using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseDialogue : MonoBehaviour
{
    public static bool GameIsPaused = false;
    // Update is called once per frame
    void Update()
    {


        
    }

    public void Resume()
    {
        Time.timeScale = 1;


    }

    public void Pause()
    {
        Time.timeScale = 0;
        

    }

 


}
