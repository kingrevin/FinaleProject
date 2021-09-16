using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class LapChecker : MonoBehaviour
{
    [Header("Lap Floats")]
    public float CurrentLapP1;
    public float CurrentLapP2;

    [Header("Text to show Laps")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    [Header("Lap Signs")]
    public GameObject Lap1SignP1;
    public GameObject Lap1SignP2;
    public GameObject Lap2SignP1;
    public GameObject Lap2SignP2;
    public GameObject Lap3SignP1;
    public GameObject Lap3SignP2;

    [Header("Timer Variables")]
    public float Timer;
    public GameObject TimerText;
    public GameObject FinalTimeText;

    [Header("Player 1 Lap Times")]
    public float P1Lap1Time;
    public float P1Lap2Time;
    public float P1Lap3Time;

    [Header("Player 2 Lap Times")]
    public float P2Lap1Time;
    public float P2Lap2Time;
    public float P2Lap3Time;

    [Header("Lap Time Text")]
    public GameObject Lap1P1TimeText;
    public GameObject Lap2P1TimeText;
    public GameObject Lap3P1TimeText;
    public GameObject Lap1P2TimeText;
    public GameObject Lap2P2TimeText;
    public GameObject Lap3P2TimeText;

    public 




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1Text.GetComponent<TextMeshProUGUI>().text = "Lap " + CurrentLapP1 + " /3";
        Player2Text.GetComponent<TextMeshProUGUI>().text = "Lap " + CurrentLapP2 + " /3";
        Lap1P1TimeText.GetComponent<TextMeshProUGUI>().text = "Lap 1: " + P1Lap1Time;
        Lap2P1TimeText.GetComponent<TextMeshProUGUI>().text = "Lap 2: " + P1Lap2Time;
        Lap3P1TimeText.GetComponent<TextMeshProUGUI>().text = "Lap 3: " + P1Lap3Time;
        Lap1P2TimeText.GetComponent<TextMeshProUGUI>().text = "Lap 1: " + P2Lap1Time;
        Lap2P2TimeText.GetComponent<TextMeshProUGUI>().text = "Lap 2: " + P2Lap2Time;
        Lap3P2TimeText.GetComponent<TextMeshProUGUI>().text = "Lap 3: " + P2Lap3Time;
        Timer += Time.deltaTime;

        TimerText.GetComponent<TextMeshProUGUI>().text = "Time: " + Timer.ToString();
        FinalTimeText.GetComponent<TextMeshProUGUI>().text = "Final Time: " + Timer;

        if (CurrentLapP1 == 1)
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
        if (CurrentLapP1 == 2)
        {
            P1Lap1Time = Timer;
        }
        if (CurrentLapP1 == 3)
        {
            P1Lap2Time = Timer - P1Lap1Time;
        }
        if (CurrentLapP1 == 4)
        {
            P1Lap3Time = Timer - P1Lap1Time - P1Lap2Time;
        }
        if (CurrentLapP2 == 2)
        {
            P2Lap1Time = Timer;
        }
        if (CurrentLapP2 == 3)
        {
            P2Lap2Time = Timer - P1Lap1Time;
        }
        if (CurrentLapP2 == 4)
        {
            P2Lap3Time = Timer - P1Lap1Time - P1Lap2Time;
        }
    }
}
