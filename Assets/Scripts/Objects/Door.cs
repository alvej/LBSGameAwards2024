using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameState gameState;
    private bool changedText = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Physics2D.OverlapCircle(transform.position, 0.5f, LayerMask.GetMask("Player")))
        {
            if (changedText == false)
            {
                changedText = true;
                gameState.infoText.text = "Press E to open the door";
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

    }
}
