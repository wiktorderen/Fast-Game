using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject Count_down;
    public GameObject LapTimer;
    public GameObject CarControlls;
    public AudioSource Step;
    public AudioSource Go;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        Count_down.GetComponent<Text>().text = "3";
        Step.Play();
        Count_down.SetActive(true);
        yield return new WaitForSeconds(1);
        Count_down.SetActive(false);
        Count_down.GetComponent<Text>().text = "2";
        Step.Play();
        Count_down.SetActive(true);
        yield return new WaitForSeconds(1);
        Count_down.SetActive(false);
        Count_down.GetComponent<Text>().text = "1";
        Step.Play();
        Count_down.SetActive(true);
        yield return new WaitForSeconds(1);
        Count_down.SetActive(false);
        Go.Play();
        LapTimer.SetActive(true);
        CarControlls.SetActive(true);
    }
}
