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

    public Movement movement;
    public DialogueTeacher2 dialogue;

    void Awake()
    {
        dialogue.GetComponent<DialogueTeacher1>();
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

            if(Input.GetKeyDown(KeyCode.E) && dialogue.inDialogue == false)
            {
                seated = true;
                gameState.infoText.text = "";

                dialogue.StartDialogue();

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
