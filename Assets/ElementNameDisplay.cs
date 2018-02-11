using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementNameDisplay : MonoBehaviour
{
    public Text elementLabel;
    public static string elementSymbolsFull, elementNamesFull;
    public static string[] elementSymbols, elementNames;
    public void Awake()
    {
        elementSymbols= System.IO.File.ReadAllLines(@"C:\Users\p_het\OneDrive\Documentos\FPS counter\Assets\elementSymbols.txt");
        elementNames= System.IO.File.ReadAllLines(@"C:\Users\p_het\OneDrive\Documentos\FPS counter\Assets\elementNames.txt"); 
    }
    public void Update()
    {
        elementLabel.text = (elementSymbols[Spawner.elementNumber-1] + " - " + elementNames[Spawner.elementNumber-1]);
    }
}
