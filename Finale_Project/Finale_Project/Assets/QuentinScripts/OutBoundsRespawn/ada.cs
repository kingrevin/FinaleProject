using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ada : MonoBehaviour
{
    public Transform checkPoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<carControl>().checkPoint = checkPoint.position;
        }
        if (col.gameObject.tag == "Player2")
        {
            col.gameObject.GetComponent<carControl2>().checkPoint = checkPoint.position;
        }
    }
}
