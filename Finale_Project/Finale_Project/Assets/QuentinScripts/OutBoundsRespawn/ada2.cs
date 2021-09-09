using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ada2 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<carControl>().LoadCheckPoint();
        }
        if (col.gameObject.tag == "Player2")
        {
            col.gameObject.GetComponent<carControl2>().LoadCheckPoint();
        }
    }
}
