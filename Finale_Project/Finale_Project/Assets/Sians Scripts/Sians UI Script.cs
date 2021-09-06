using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SiansUIScript : MonoBehaviour
{
    public int Playerscore;
    public float Timer;
    public GameObject WinnerScreen;
    public GameObject PlayerScoreText;
    public GameObject TimerText;
    public GameObject GameScreen;
    public GameObject FinalScore;



    // Start is called before the first frame update
    void Start()
    {

    }



    private void Update()
    {
        Timer += Time.deltaTime;
        PlayerScoreText.GetComponent<TextMeshProUGUI>().text = Playerscore.ToString();
        TimerText.GetComponent<TextMeshProUGUI>().text = "Time: " + Timer.ToString();
        FinalScore.GetComponent<TextMeshProUGUI>().text = "Final Score: " + Playerscore.ToString();
        if (Timer >= 200)
        {
            GameScreen.SetActive(false);
            WinnerScreen.SetActive(true);
        }
    }
}
