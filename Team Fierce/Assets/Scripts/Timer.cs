using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class Timer : MonoBehaviour
{
    public string levelToLoad;
    public float timer = 10f;
    private Text timerSecond;

    // Use this for initialization
    void Start()
    {
        timerSecond = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSecond.text = timer.ToString("f2");
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);

        }
    }
}