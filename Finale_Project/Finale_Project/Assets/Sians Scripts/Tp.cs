using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            p2.GetComponent<carControl2>().LoadCheckPoint();
        }
        if (Input.GetKey(KeyCode.F))
        {
            p1.GetComponent<carControl>().LoadCheckPoint();
        }
    }
}
