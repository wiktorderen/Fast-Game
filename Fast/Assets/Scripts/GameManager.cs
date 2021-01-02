using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject needele;
    private float startPosition = 220f, endPosition = - 41;
    private float desiredPosition;

    public float speed;


    public void updateNeedele()
    {
        desiredPosition = startPosition - endPosition;
        float tmp = speed / 180;
        needele.transform.eulerAngles = new Vector3(0, 0, (startPosition - tmp * desiredPosition));
    }
}
