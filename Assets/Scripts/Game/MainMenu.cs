
//Code referenced from tutorial https://www.youtube.com/watch?v=2PKBChN10us 
//Additionally referenced from https://www.youtube.com/watch?v=zc8ac_qUXQY
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Character Selection");
    }//Character Selection

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
