using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    public Movement movement;
    void Start()
    {
        movement = FindObjectOfType<Movement>();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        movement.changeCamera = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        movement.changeCamera = true;
    }
}
