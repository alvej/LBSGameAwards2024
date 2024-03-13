using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueTeacher1 : MonoBehaviour
{
    public string[] lines;
    public float waitSeconds;
    public GameObject dialogueSquare;

    private int index;

    public int dialogue = 0;
    public bool inDialogue = false;

    private GameState gameState;
    private bool changedText = false;


    void Start()
    {
        gameState = FindObjectOfType<GameState>();
        gameState.teacherDialogueText.text = string.Empty;
    }




    void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, 1f, LayerMask.GetMask("Player")))
        {
            if (changedText == false && dialogue == 0)
            {
                changedText = true;
                gameState.infoText.text = "Press E to talk to Teacher";
            }

            if (Input.GetKeyDown(KeyCode.E) && inDialogue == false)
            {
                if (dialogue == 0)
                {
                    StartDialogue();
                }

                inDialogue = true;
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


        if (Input.GetMouseButtonDown(0))
        {
            if (gameState.teacherDialogueText.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                gameState.teacherDialogueText.text = lines[index];
            }
        }
    }

  

    public void StartDialogue()
    {

        dialogue++;
        gameState.dialogueSquare.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }


    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            gameState.teacherDialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogue++;
            inDialogue = false;
            gameState.dialogueSquare.SetActive(false);
            gameState.infoText.text = "";
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            gameState.teacherDialogueText.text += c;
            yield return new WaitForSeconds(waitSeconds);
        }
    }
}
