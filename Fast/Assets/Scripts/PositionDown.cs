using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionDown : MonoBehaviour
{
    public GameObject positionDisplay;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CarPosition")
        {
            positionDisplay.GetComponent<Text>().text = "2nd place";
        }
    }
}
