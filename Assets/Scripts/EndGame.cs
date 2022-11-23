using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;     

public class EndGame : MonoBehaviour
{
    public void PlayAgain(){
        SceneManager.LoadScene("Game");
    }    
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
