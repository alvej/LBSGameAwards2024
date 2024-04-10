using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{

    public GameObject tranOut;
    public GameObject playButton;
    public GameState gameState;

    public Animator anim;

    void Start()
    {
        gameState = FindObjectOfType<GameState>();
        LeanTween.scale(playButton, Vector3.one * 3.3f, 0.2f).setEase(LeanTweenType.easeOutQuad);
    }

    // When the mouse cursor enters the button area
    public void OnPointerEnter()
    {
        LeanTween.cancel(playButton);

        LeanTween.scale(playButton, Vector3.one * 3.7f, 0.35f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnPointerExit()
    {
        LeanTween.cancel(playButton);

        LeanTween.scale(playButton, Vector3.one * 3.3f, 0.35f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnClick()
    {
        gameState.timerEnabled = true;
        StartCoroutine(Transition());
    }

    private IEnumerator Transition()
    {
        yield return new WaitForSeconds(1.5f);

        tranOut.SetActive(true);
        anim.SetBool("startTran", true);

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Opening CutScene");
        yield return new WaitForSeconds(0.25f);
        anim.SetBool("startTran", false);
        tranOut.SetActive(false);
    }
}
