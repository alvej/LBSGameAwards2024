using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorridorSwitch : MonoBehaviour
{
    public GameObject player;

    public Movement movement;
    public int room = 1;
    public string changeTo;
    void Start()
    {
        movement = FindObjectOfType<Movement>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (room == 1)
        {
            SceneManager.LoadScene(changeTo);
            room = 2;
        }
        else if (room == 2)
        {
            SceneManager.LoadScene(changeTo);
            room = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    void Update()
    {
        
    }
}
