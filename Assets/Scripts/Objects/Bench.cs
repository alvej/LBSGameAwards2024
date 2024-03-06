using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bench : MonoBehaviour
{
    private bool seated = false;

    public GameState gameState;
    private bool changedText = false;

    public DialogueTeacher2 dialogue;
    public Movement movement;

    void Awake()
    {
        dialogue = FindObjectOfType<DialogueTeacher2>();
        gameState = FindObjectOfType<GameState>();
        GameObject.FindWithTag("Player").GetComponent<Movement>();
    }


    void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, 1.5f, LayerMask.GetMask("Player")))
        {
            if (changedText == false && seated == false)
            {
                changedText = true;
                gameState.infoText.text = "Press E to sit down";

            }

            if (Input.GetKeyDown(KeyCode.E) && seated == false)
            {
                seated = true;
                Debug.Log("ye");

                dialogue.StartDialogue();
                gameState.infoText.text = "";

                //Transition anim så att man sätter sig ner.
            }


        }
        else
        {
            if (changedText == true)
            {
                changedText = false;
                gameState.infoText.text = "";
            }
        }

        if(seated == true)
        {
            movement.speed = 0;
        }
        else if (seated == false)
        {
            movement.speed = 5;
        }
    }
}
