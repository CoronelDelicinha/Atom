﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public int AverageFPS { get; private set; }
    public int frameRange;
    int[] fpsBuffer;
    int fpsBufferIndex;
    public int HighestFPS { get; private set; }
    public int LowestFPS { get; private set; }
    void InitializeBuffer()
    {
        if (frameRange<=0)
        {
            frameRange = 1;
        }
        fpsBuffer = new int[frameRange];
        fpsBufferIndex = 0;
    }
    void UpdateBuffer()
    {
        fpsBuffer[fpsBufferIndex++] = (int)(1f / Time.unscaledDeltaTime);
        if (fpsBufferIndex>=frameRange)
        {
            fpsBufferIndex = 0;
        }
    }
    void CalculateFPS()
    {
        int sum = 0;
        int highest = 0;
        int lowest = int.MaxValue;
        for (int it1 =0; it1<frameRange;it1++)
        {
            int fps = fpsBuffer[it1];
            sum += fps;
            if (fps>highest)
            {
                highest = fps;
            }
            if (fps<lowest)
            {
                lowest = fps;
            }
        }
        AverageFPS = sum / frameRange;
        HighestFPS = highest;
        LowestFPS = lowest;
    }
    private void Update()
    {
        if (fpsBuffer == null||fpsBuffer.Length!=frameRange)
        {
            InitializeBuffer();
        }
        UpdateBuffer();
        CalculateFPS();
    }
}