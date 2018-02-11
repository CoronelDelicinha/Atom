using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronSpawner : MonoBehaviour {
    
    public struct ElectronStruct
    {
        public float distance;
        public Material color;
        public string tag;
        public Electron electronPrefab;
        public int camNumber;
    }
    public static ElectronStruct elect;

    public void Awake()
    {
        elect.camNumber = 0;
    }
    public static void SpawnElectron(Electron electronPrefab, Material[] colors)
    {
        elect.electronPrefab = electronPrefab;
        Electron prefab = elect.electronPrefab;
        Electron spawn = Instantiate<Electron>(prefab);
        elect = ElectronSettings(elect, colors);
        Layer(elect.distance, spawn);
        Spawner.ElectronNumber++;
    }
    public static ElectronStruct ElectronSettings (ElectronStruct elect, Material [] colors)
    {
        if (Spawner.ElectronNumber < 2)
        {
            elect.distance = 2;
            elect.electronPrefab.tag = "1";
            elect.color = colors[0];
            elect.camNumber = 0;
            return elect;
        }
        if (Spawner.ElectronNumber < 10)
        {
            elect.distance = 3;
            elect.electronPrefab.tag = "2";
            elect.color = colors[1];
            elect.camNumber = 0;
            return elect;
        }
        if (Spawner.ElectronNumber < 18)
        {
            elect.distance = 4;
            elect.electronPrefab.tag = "3";
            elect.color = colors[2];
            elect.camNumber = 1;
            return elect;
        }
        if (Spawner.ElectronNumber < 34)
        {
            elect.distance = 5;
            elect.electronPrefab.tag = "4";
            elect.color = colors[3];
            elect.camNumber = 2;
            return elect;
        }
        if (Spawner.ElectronNumber < 66)
        {
            elect.distance = 6;
            elect.electronPrefab.tag = "5";
            elect.color = colors[4];
            elect.camNumber = 3;
            return elect;
        }
        if (Spawner.ElectronNumber < 82)
        {
            elect.distance = 7;
            elect.electronPrefab.tag = "6";
            elect.color = colors[5];
            elect.camNumber = 4;
            return elect;
        }
        if (Spawner.ElectronNumber < 90)
        {
            elect.distance = 8;
            elect.electronPrefab.tag = "7";
            elect.color = colors[6];
            elect.camNumber = 4;
            return elect;
        }
        if (Spawner.ElectronNumber >= 90)
        {
            elect.distance = 9;
            elect.electronPrefab.tag = "8";
            elect.color = colors[7];
            elect.camNumber = 4;
            return elect;
        }
        return elect;
    }
    public static void Layer(float dist, Electron spawn)
    {
        spawn.transform.localPosition = Random.onUnitSphere * (Spawner.spawnDistance - 10) * dist;
        Renderer rend = spawn.GetComponent<Renderer>();
        rend.material = elect.color;
    }
}
