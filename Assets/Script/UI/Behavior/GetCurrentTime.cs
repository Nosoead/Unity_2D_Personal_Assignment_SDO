using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class GetCurrentTime : MonoBehaviour
{
    [SerializeField] private Text TimeText;
    private DateTime currentTime;
    // Update is called once per frame
    void Update()
    {
        SetCurrentTime();
    }

    private void SetCurrentTime()
    {
        currentTime = DateTime.Now;
        ApplyCurrentTime();
    }
    private void ApplyCurrentTime()
    {
        TimeText.text = currentTime.ToString("HH:mm:ss");
    }
}
