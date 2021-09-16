using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SiansUIScript : MonoBehaviour
{
  
    public float Timer;
    public GameObject TimerText;
    public GameObject GameScreen;
    public GameObject FinalScoreScreen;
    public GameObject FinalTimeText;
    public GameObject WinnerText;
    public LapChecker LapScript;



    // Start is called before the first frame update
    void Start()
    {

    }



    private void Update()
    {
        Timer += Time.deltaTime;
        
        TimerText.GetComponent<TextMeshProUGUI>().text = "Time: " + Timer.ToString();
        FinalTimeText.GetComponent<TextMeshProUGUI>().text = "Final Time: " + Timer;

        if (LapScript.CurrentLapP1 >= 4)
        {
            GameScreen.SetActive(false);
            FinalScoreScreen.SetActive(true);
            WinnerText.GetComponent<TextMeshProUGUI>().text = "Player 1 wins!";
            Time.timeScale = 0;
        }
        else if (LapScript.CurrentLapP2 >= 4)
        {
            GameScreen.SetActive(false);
            FinalScoreScreen.SetActive(true);
            WinnerText.GetComponent<TextMeshProUGUI>().text = "Player 2 wins!";
            Time.timeScale = 0;

        }
    }
}
