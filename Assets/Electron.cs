using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Electron : MonoBehaviour
{
    public float speed;
    Rigidbody body;
    Vector3 angle;
    int temp;
 
    void Awake()
    {
        angle = Vector3.zero;
        body = GetComponent<Rigidbody>();
        do
        {
            for (int it1 = 0; it1 < 6; it1++)
            {
                temp = Random.Range(1, 6);
                if (temp == 1)
                {
                    angle.x = 0.1f;
                }
                else if (temp == 2)
                {
                    angle.y = 0.1f;
                }
                else if (temp == 3)
                {
                    angle.z = 0.1f;
                }
                else if (temp == 4)
                {
                    angle.x = -0.1f;
                }
                else if (temp == 5)
                {
                    angle.y = -0.1f;
                }
                else if (temp == 6)
                {
                    angle.z = -0.1f;
                }
            }
        } while (angle == Vector3.zero);
    }
    void FixedUpdate()
    {
        body.transform.RotateAround(Vector3.zero, angle/*how to vary the axis and the orientation without changing its position?it starts at a random point in the sphere. axis distance should be the sphere radius*/, speed * Time.deltaTime);
    }
}
