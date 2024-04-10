using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorChange : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform doorOpen;
    public Transform doorClosed;
    private GameState gameState;
    public bool unlockDoors = false;

    void Start()
    {
        gameState = FindObjectOfType<GameState>();

        if(gameState.lastScene == "MathBook")
        {
            gameState.taskText.text = "Task: Go to the bathroom";

            if(unlockDoors == false) {
                doorOpen.gameObject.SetActive(false);
                doorClosed.gameObject.SetActive(true);
                gameObject.SetActive(false);
            } else
            {
                doorOpen.gameObject.SetActive(true);
                doorClosed.gameObject.SetActive(false);
            }
            
        }
        else
        {

            gameState.taskText.text = "Task: Go to class";

            if (unlockDoors == false)
            {
                doorOpen.gameObject.SetActive(true);
                doorClosed.gameObject.SetActive(false);
            }
            else
            {
                doorOpen.gameObject.SetActive(false);
                doorClosed.gameObject.SetActive(true);
                gameObject.SetActive(false);

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
