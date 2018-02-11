using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleonSpawner : MonoBehaviour
{
    public static void SpawnNucleon(int nucleonPrefabNumber, Nucleon [] nucleonPrefabs)
    {
        Nucleon prefab = nucleonPrefabs[nucleonPrefabNumber];
        Nucleon spawn = Instantiate<Nucleon>(prefab);
        spawn.transform.localPosition = Random.onUnitSphere * Spawner.spawnDistance;
        Spawner.NucleonNumber++;
    }
}
/*DONE Fix distances when lowering electronNumber*/
/*TODO FIX THE FUCKING AXIS*/
/*TODO fix camera issue*/
/*DONE out why line 54 is 86ing*/
/*TODO find out why the in-game slider isnt interactable*/
/*(kinda) DONE find a way around the static/non static problem*/