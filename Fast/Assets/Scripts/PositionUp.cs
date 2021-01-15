using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionUp : MonoBehaviour
{
    public GameObject positionDisplay;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CarPosition")
        {
            positionDisplay.GetComponent<Text>().text = "1st place";
        }
    }
}
