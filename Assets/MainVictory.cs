using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainVictory : MonoBehaviour
{
    public void RestartGame()
    {
      SceneManager.LoadSceneAsync("MainScene");
    }

    public void backMenu()
    {
      SceneManager.LoadSceneAsync("Main Menu");
    }

    public void QuitGame()
    {
      Application.Quit();
    }
}
