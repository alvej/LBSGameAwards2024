using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Pen : MonoBehaviour
{
    public RectTransform pen;
    public GameObject drawPrefab;

    public TextMeshProUGUI text;


    int count = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        Vector3 penPos = pen.position;

        pen.position = mousePos;


        if(Input.GetMouseButtonDown(0))
        {

            count++;
            Debug.Log("Math book damaged: " + count + " times.");
            text.text = "Score: " + count;
            Instantiate(drawPrefab, pen.position, Quaternion.identity, transform.parent);
            
        }
        
    }
}
