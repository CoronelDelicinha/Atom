using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    public struct ElectronStorage
    {
        public GameObject[] taggedElectrons;
    }
    public static string[] tags = { "1", "2", "3", "4", "5", "6", "7", "8" };
    public static void DestroyElectron()
    {
        ElectronStorage[] electronLayers = new ElectronStorage[8];
        for (int it1 = 0; it1 < 8; it1++)
        {
            electronLayers[it1].taggedElectrons = GameObject.FindGameObjectsWithTag(tags[it1]);
        }
        bool empty = true;
        for (int it1 = 7; it1 >= 0 && empty == true; it1--)
        {
            if (electronLayers[it1].taggedElectrons.Length > 0)
            {
                empty = false;
                Destroy(electronLayers[it1].taggedElectrons[electronLayers[it1].taggedElectrons.Length - 1]);

            }
        }
    }
    public static void DestroyNucleon()
    {
        GameObject[] destroyNucleon;
        destroyNucleon = GameObject.FindGameObjectsWithTag("Nucleon");
        Destroy(destroyNucleon[0].gameObject);
        Destroy(destroyNucleon[1].gameObject);
    }
}
