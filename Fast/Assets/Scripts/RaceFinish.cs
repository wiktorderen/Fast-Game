using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject Car;
    public GameObject FinishCam;
    public GameObject ViewMode;
    public GameObject CompleteTrig;

    void OnTriggerEnter()
    {
        Car.SetActive(false);
        CompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        Car.GetComponent<CarController>().enabled = false;
        Car.GetComponent<CarUserControl>().enabled = false;
        Car.SetActive(true);
        FinishCam.SetActive(true);
        ViewMode.SetActive(false);
    }
}
