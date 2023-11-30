using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timeur : MonoBehaviour
{
    float time;
    public float TimeurInterval = 5f;
    float tick;

    void Awake()
    {
        time = 57 * 60 + (int)Time.time;
        tick = 60 * 60;
    }
    void Start()
    {

    }

    void Update()
    {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);
        time = 57 * 60 +  (int)Time.time;
        if (time == tick)
        {
            //tick = time + TimeurInterval;
            TimerExecute();

        }
    }

    void TimerExecute()
    {
        UnityEngine.Debug.Log("timer");
        SceneManager.LoadSceneAsync("Main GameOver");
        // Envoyer à la scéne de mort
    }
}
