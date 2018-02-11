using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float timeBetweenSpawns;
    public static float spawnDistance;
    public Nucleon[] nucleonPrefabs;
    public Electron electronPrefab;
    float timeSinceLastSpawn;
    public static int elementNumber;
    public static int NucleonNumber { get; set; }
    public static int ElectronNumber { get; set; }
    public static Vector3 Position { get; private set; }
    public Material[] colors;

    private void Awake()
    {
        spawnDistance = 15;
        NucleonNumber = 0;
        ElectronNumber = 0;
        elementNumber = SliderValue.atom;
    }
    private void FixedUpdate()
    {
        elementNumber = SliderValue.atom;
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawns)
        {
            timeSinceLastSpawn -= timeBetweenSpawns;
            if (NucleonNumber / 2 < elementNumber)
            {
                NucleonSpawner.SpawnNucleon(0,nucleonPrefabs);
                NucleonSpawner.SpawnNucleon(1,nucleonPrefabs);
                ElectronSpawner.SpawnElectron(electronPrefab, colors);
            }
            if (ElectronNumber > elementNumber)
            {
                Destroyer.DestroyNucleon();
                Destroyer.DestroyElectron();
                ElectronSpawner.elect = ElectronSpawner.ElectronSettings(ElectronSpawner.elect, colors);
                ElectronNumber--;
                NucleonNumber -= 2;
            }
        }
    }
}
