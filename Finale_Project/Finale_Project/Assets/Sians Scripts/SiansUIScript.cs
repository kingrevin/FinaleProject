using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SiansUIScript : MonoBehaviour
{
  
    
    public GameObject GameScreen;
    public GameObject FinalScoreScreen;
   
    public GameObject WinnerText;
    public LapChecker LapScript;
    public float Lap1Timer;



    // Start is called before the first frame update
    void Start()
    {

    }



    private void Update()
    {
        

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
