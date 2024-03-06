using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public GameObject playButton;

    void Start()
    {
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
        SceneManager.LoadScene("Corridor");
    }

}
