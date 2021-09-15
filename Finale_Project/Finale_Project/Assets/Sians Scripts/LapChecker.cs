using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class LapChecker : MonoBehaviour
{

    public int CurrentLapP1;
    public int CurrentLapP2;

    public GameObject Player1Text;
    public GameObject Player2Text;

    public GameObject Lap1SignP1;
    public GameObject Lap1SignP2;
    public GameObject Lap2SignP1;
    public GameObject Lap2SignP2;
    public GameObject Lap3SignP1;
    public GameObject Lap3SignP2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1Text.GetComponent<TextMeshProUGUI>().text = CurrentLapP1.ToString();
        Player2Text.GetComponent<TextMeshProUGUI>().text = CurrentLapP2.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            CurrentLapP1++;
        }
        else if (other.gameObject.tag == "Player2")
        {
            CurrentLapP2++;
        }
    }
}
