using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    }


    void Start()
    {
        gameState = FindObjectOfType<GameState>();
        textComponent.text = string.Empty;
    }




    void Update()
    {

        if (Input.GetMouseButtonDown(0) && inDialogue == true)
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

  

    public void StartDialogue()
    {
        gameState.infoText.text = "";

        inDialogue = true;

        dialogue++;
        dialogueSquare.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }


    void NextLine()
    {
        if (index < 6)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            inDialogue = false;
            dialogueSquare.SetActive(false);
            gameState.infoText.text = "";
            SceneManager.LoadScene("DestroyMathBook");
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
