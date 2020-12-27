using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public Rigidbody Car;
    public float MaxSpeed = 200f;
    public float MinArrowAngle; 
    public float MaxArrowAngle;

    [Header("UO")]

    public RectTransform Arrow;
    public float speed = 0.0f;

    void Update()
    {
        speed = Car.velocity.magnitude * 3.6f;

        if(Arrow != null)
        {
            Arrow.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(MinArrowAngle, MaxArrowAngle, speed / MaxSpeed));
        }
    }
}