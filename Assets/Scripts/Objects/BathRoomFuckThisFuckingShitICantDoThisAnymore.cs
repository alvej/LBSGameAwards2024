using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathRoomFuckThisFuckingShitICantDoThisAnymore : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite grafittiBathroom;
    public Transform bathroom;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E)) { 
            bathroom.GetComponent<SpriteRenderer>().sprite = grafittiBathroom;
        }
        
    }
}

