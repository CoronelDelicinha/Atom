using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Camera centerOfStage;
    public static float speed = 5f;
    public static Vector3 [] camPos = new Vector3 [5];

    void Start()
    {
        for (int zeta = -30, it1=0;it1<camPos.Length;it1++, zeta -=10)
        {
            camPos[it1].z = zeta;
        }
    }
    void Update ()
    {
        centerOfStage.transform.position = Vector3.Lerp(centerOfStage.transform.position, camPos[ElectronSpawner.elect.camNumber], speed * Time.deltaTime);
    }
}
