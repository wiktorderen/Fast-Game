using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;

    void OnTiggerEnter()
    {
        if(LapTime.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTime.SecondCount + ",";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTime.SecondCount + ",";
        }


        if (LapTime.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTime.MinuteCount + ",";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTime.MinuteCount + ",";
        }

        MiliDisplay.GetComponent<Text>().text = "" + LapTime.MiliSecCount;

        LapTime.MinuteCount = 0;
        LapTime.SecondCount = 0;
        LapTime.MiliSecCount = 0;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
