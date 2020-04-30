using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text WhowonTxt;

    void Update()
    {
        if(PlayerMovement.player1score > PlayerMovement.player2score)
        {
            WhowonTxt.text = "P L A Y E R  1  W O N";
        }
        else if(PlayerMovement.player2score > PlayerMovement.player1score)
        {
            WhowonTxt.text = "P L A Y E R  2  W O N";
        }
        else
        {
            WhowonTxt.text = "I T'S  A  D R A W";
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void goToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
 
}
