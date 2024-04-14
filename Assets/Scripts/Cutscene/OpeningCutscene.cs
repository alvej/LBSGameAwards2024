using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningCutscene : MonoBehaviour
{

    public GameState gameState;

    public TextMeshProUGUI timeText;
    public TextMeshProUGUI taskText;

    public Animator anim;
    void Start()
    {
        gameState = GameObject.Find("GameState").GetComponent<GameState>();
        anim.SetBool("startCutscene", true);

        StartCoroutine(AnimationTimer());
    }

    void Update()
    {
        
    }

    private IEnumerator AnimationTimer()
    {
        yield return new WaitForSeconds(5.7f);

        anim.SetBool("startCutscene", false);

        gameState.timerEnabled = true;

        SceneManager.LoadScene("Corridor");

    }
}
