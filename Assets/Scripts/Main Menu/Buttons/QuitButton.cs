using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{

    public GameObject quitButton;

    void Start()
    {
        LeanTween.scale(quitButton, Vector3.one * 3.3f, 0.2f).setEase(LeanTweenType.easeOutQuad);
    }

    // When the mouse cursor enters the button area
    public void OnPointerEnter()
    {
        LeanTween.cancel(quitButton);
      
        LeanTween.scale(quitButton, Vector3.one * 3.7f, 0.35f).setEase(LeanTweenType.easeOutQuad);
     
       
    }

    public void OnPointerExit()
    {
        LeanTween.cancel(quitButton);

        LeanTween.scale(quitButton, Vector3.one * 3.3f, 0.35f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnClick()
    {
        Application.Quit();
    }

}
