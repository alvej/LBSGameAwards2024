using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bench : MonoBehaviour
{
    private bool seated = false;

    public GameState gameState;
    private bool changedText = false;

    public DialogueTeacher1 check;
    public DialogueTeacher2 dialogue;
    public Movement movement;

    public Animator animIn;
    public Animator animOut;
    public GameObject tranOut;
    public GameObject tranIn;

    public GameObject player;
    public GameObject playerSeated;

    void Awake()
    {
        check = FindObjectOfType<DialogueTeacher1>();
        dialogue = FindObjectOfType<DialogueTeacher2>();
        gameState = FindObjectOfType<GameState>();
        GameObject.FindWithTag("Player").GetComponent<Movement>();
    }


    void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, 1.5f, LayerMask.GetMask("Player")) && check.dialogue >= 1)
        {
            if (changedText == false && seated == false)
            {
                changedText = true;
                gameState.infoText.text = "Press E to sit down";

            }

            if (Input.GetKeyDown(KeyCode.E) && seated == false)
            {
                seated = true;

                StartCoroutine(Transition());

                Debug.Log("ye");


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

    private IEnumerator Transition()
    {
        animOut.SetBool("deskOut", true);
        tranOut.SetActive(true);
        yield return new WaitForSeconds(1);
        animOut.SetBool("deskOut", false);
        tranOut.SetActive(false);

        player.SetActive(false);
        playerSeated.SetActive(true);

        animIn.SetBool("deskIn", true);
        tranIn.SetActive(true);
        yield return new WaitForSeconds(1);
        

        dialogue.StartDialogue();
        gameState.infoText.text = "";
    }
}
