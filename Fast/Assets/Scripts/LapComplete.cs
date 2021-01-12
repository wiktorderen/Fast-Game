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

    public GameObject LapCounter;
    public int Laps;

    public float RawTime;
    public GameObject RaceFinish;

    void Update()
    {
        if(Laps == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTiggerEnter()
    {
        Laps += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTime.RawTime <= RawTime)
        {
            if (LapTime.SecondCount <= 9)
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
        }

        PlayerPrefs.SetInt("MinSave", LapTime.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTime.SecondCount);
        PlayerPrefs.SetFloat("MiliSave", LapTime.MiliSecCount);
        PlayerPrefs.SetFloat("RawTime", LapTime.RawTime);

        LapTime.MinuteCount = 0;
        LapTime.SecondCount = 0;
        LapTime.MiliSecCount = 0;
        LapTime.RawTime = 0;

        LapCounter.GetComponent<Text>().text = "" + Laps;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }
}
