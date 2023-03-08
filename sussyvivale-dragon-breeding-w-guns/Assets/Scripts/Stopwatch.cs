using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    float currentTime;

    public TMP_Text timeText;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        currentTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timeText.text = "Time = " + time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }
}
