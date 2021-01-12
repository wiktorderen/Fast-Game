using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject MaskCam;
    public int CurrentCam;
    void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            if(CurrentCam == 2)
            {
                CurrentCam = 0;
            }
            else
            {
                CurrentCam += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CurrentCam == 0)
        {
            NormalCam.SetActive(true);
            MaskCam.SetActive(false);
        }
        if(CurrentCam == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if(CurrentCam == 2)
        {
            MaskCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}