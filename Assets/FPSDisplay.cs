using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[RequireComponent (typeof(FPSCounter))]
public class FPSDisplay : MonoBehaviour
{
    [System.Serializable]
    private struct FPSColor
    {
        public Color color;
        public int minimumFPS;
    }
    [SerializeField]
    private FPSColor[] coloring;
    public Text highestFPSLabel,lowestFPSLabel,averageFPSLabel;
    FPSCounter fpsCounter;
    static string[] stringsFrom00To99;

    private void Awake()
    {
        stringsFrom00To99  = System.IO.File.ReadAllText(@"C:\Users\p_het\OneDrive\Documentos\FPS counter\Assets\strings00to99.txt").Split(null);
        fpsCounter = GetComponent<FPSCounter>();
    }
    private void Update()
    {
        Display(highestFPSLabel,fpsCounter.HighestFPS);
        Display(lowestFPSLabel,fpsCounter.LowestFPS);
        Display(averageFPSLabel,fpsCounter.AverageFPS);
    }
    void Display(Text label, int fps)
    {
        label.text = stringsFrom00To99[Mathf.Clamp(fps, 0, 99)];
        for (int it1 = 0; it1 < coloring.Length; it1++)
        {
            if (fps >= coloring[it1].minimumFPS)
            {
                label.color = coloring[it1].color;
                break;
            }
        }
    }
}
