using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControllActivate : MonoBehaviour
{
    public GameObject Car;
    public GameObject CarAI;

    void Start()
    {
        StartCoroutine(wait());
       
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        Car.GetComponent<CarController>().enabled = true;
        CarAI.GetComponent<CarController>().enabled = true;
    }
}
