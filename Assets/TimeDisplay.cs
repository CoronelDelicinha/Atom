using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeLabel;
    private void Update()
    {
        timeLabel.text = Time.realtimeSinceStartup.ToString("F1")+" Seconds";
    }
}
