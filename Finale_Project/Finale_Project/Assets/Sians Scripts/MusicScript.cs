using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("CountDown");
        FindObjectOfType<AudioManager>().Play("BGMusic");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
