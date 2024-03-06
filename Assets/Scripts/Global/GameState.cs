using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameState : MonoBehaviour
{


    public TextMeshProUGUI infoText;

    public GameObject dialogueSquare;
    public TextMeshProUGUI teacherDialogueText;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        infoText.text = "";


    }

    // Update is called once per frame
    void Update()
    {


    }
}
