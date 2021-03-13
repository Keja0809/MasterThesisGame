using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class PausingGame : MonoBehaviour
{
    //public Flowchart flowchart;
       
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        Time.timeScale = 1; 
    }


}
