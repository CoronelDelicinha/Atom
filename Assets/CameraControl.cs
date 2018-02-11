using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraControl : MonoBehaviour {

    public Camera centerOfStage;
    public static float speed = 5f;
    public static Vector3 [] camPos = new Vector3 [8];

    void Start()
    {
        for (int zeta = -40, it1=0;it1<camPos.Length;it1++, zeta -=10)
        {
            camPos[it1].z = zeta;
        }
    }
    public static void SetCamDis (int camNumber)
    {
       /* centerOfStage.transform.position = Vector3.Lerp(centerOfStage.transform.position, camPos[camNumber], speed * Time.deltaTime);*/
    }
}
