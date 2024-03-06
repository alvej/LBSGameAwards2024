using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueTeacher2 : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float waitSeconds;
    public GameObject dialogueSquare;

    private int index;

    public int dialogue = 0;
    public bool inDialogue = false;

    private GameState gameState;
    private bool changedText = false;


    DialogueTeacher1 dialogue1;

    private void Awake()
    {
        //referenca dialog1 o s� fixar du s� det blir detta scripts dialog.
    }


    void Start()
    {
        gameState = FindObjectOfType<GameState>();
        gameState.teacherTalkText.text = "";
        textComponent.text = string.Empty;
    }




    void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, 1f, LayerMask.GetMask("Player")))
        {
            if (changedText == false && dialogue == 0)
            {
                changedText = true;
                gameState.teacherTalkText.text = "Press E to talk to Teacher";
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
                gameState.teacherTalkText.text = "";
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

  

    void StartDialogue()
    {
        dialogue++;
        dialogueSquare.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }


    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            inDialogue = false;
            dialogueSquare.SetActive(false);
            gameState.teacherTalkText.text = "";
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(waitSeconds);
        }
    }
}
