using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllActivate : MonoBehaviour
{
    public GameObject Car;
    void Start()
    {
        Car.SetActive(true);
    }
}