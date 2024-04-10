using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{


    public TextMeshProUGUI infoText;
    public TextMeshProUGUI timeText;

    public TextMeshProUGUI taskText;

    public GameObject dialogueSquare;
    public TextMeshProUGUI teacherDialogueText;
    public string lastScene = "MainMenu";
    public float timeLeft = 120;
    public bool timerEnabled = false;
    private bool ranOut = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        infoText.text = "";


    }

    // Update is called once per frame
    void Update()
    {

        if (timeLeft > 0)
        {
            //Debug.Log(timerEnabled);
            if (timerEnabled) {
                //Debug.Log("Time left: " + timeLeft);
                timeLeft -= Time.deltaTime;
                timeText.text = "Time left: " + Math.Round(timeLeft, 0);
            }
        }
        else
        {
            timeLeft = 0;
        }

        if (timeLeft == 0 && ranOut == false)
        {
            ranOut = true;
            infoText.text = "You ran out of time!";
            Debug.Log("You ran out of time!");
            SceneManager.LoadScene("TeacherCorridor");
        }

    }
}
