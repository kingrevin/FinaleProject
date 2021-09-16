using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class LapChecker : MonoBehaviour
{

    public float CurrentLapP1;
    public float CurrentLapP2;

    public GameObject Player1Text;
    public GameObject Player2Text;

    /*public GameObject Lap1SignP1;
    public GameObject Lap1SignP2;
    public GameObject Lap2SignP1;
    public GameObject Lap2SignP2;
    public GameObject Lap3SignP1;
    public GameObject Lap3SignP2;*/
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1Text.GetComponent<TextMeshProUGUI>().text = "Lap " + CurrentLapP1 + " /3";
        Player2Text.GetComponent<TextMeshProUGUI>().text = "Lap " + CurrentLapP2 + " /3";

       /* if (CurrentLapP1 == 1)
        {
            Lap1SignP1.SetActive(true);
        }
        else if (CurrentLapP1 == 2)
        {
            Lap2SignP1.SetActive(true);
            Lap1SignP1.SetActive(false);
        }
        else if (CurrentLapP1 == 3)
        {
            Lap3SignP1.SetActive(true);
            Lap2SignP1.SetActive(false);
            Lap1SignP1.SetActive(false);
        }
        if (CurrentLapP2 == 1)
        {
            Lap1SignP2.SetActive(true);
        }
        else if (CurrentLapP2 == 2)
        {
            Lap2SignP2.SetActive(true);
            Lap1SignP2.SetActive(false);
        }
        else if (CurrentLapP2 == 3)
        {
            Lap3SignP2.SetActive(true);
            Lap2SignP2.SetActive(false);
            Lap1SignP2.SetActive(false);
        }
        if (CurrentLapP1 == 4)
        {
            Lap3SignP2.SetActive(false);
            Lap3SignP1.SetActive(false);
            
        }
       */
    }   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CurrentLapP1++;
        }
        else if (other.gameObject.tag == "Player2")
        {
            CurrentLapP2++;
        }
    }
}
