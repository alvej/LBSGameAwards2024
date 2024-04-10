using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pen : MonoBehaviour
{
    public RectTransform pen;
    public GameObject drawPrefab;

    public TextMeshProUGUI text;

    public Sprite mathbookColored;
    private GameState gameState;


    int count = 0;


    void Start()
    {
        gameState = FindObjectOfType<GameState>();
        gameState.lastScene = "MathBook";
        
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
            GameObject obj =  Instantiate(drawPrefab, pen.position, Quaternion.identity, transform.parent);
            if(count == 20) {
                transform.GetComponent<SpriteRenderer>().sprite = mathbookColored;
                StartCoroutine(ChangeScene());
            }
            
        }
        
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Corridor");
    }
}
