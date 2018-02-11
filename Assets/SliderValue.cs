using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public static int atom = 1;
    public Slider temp;
    void Start()
    {
        temp = GetComponent<Slider>();
    }
    private void Update()
    {
        atom = (int)temp.value;
    }
}
