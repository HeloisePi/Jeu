using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameOver : MonoBehaviour
{
    public void PlayGame () 
    {
        SceneManager. LoadSceneAsync (0);
    }
    public void Menu () 
    {
        SceneManager. LoadSceneAsync (1);
    }

    public void QuitGame ()
    {
       Application.Quit ();
    }
}

