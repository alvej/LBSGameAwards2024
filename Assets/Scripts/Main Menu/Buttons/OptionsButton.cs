using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour
{

    public GameObject optionsMenu;
    public GameObject buttons;

    public GameObject optionsButton;

    void Start()
    {
        LeanTween.scale(optionsButton, Vector3.one * 3.3f, 0.2f).setEase(LeanTweenType.easeOutQuad);
    }

    // When the mouse cursor enters the button area
    public void OnPointerEnter()
    {
        LeanTween.cancel(optionsButton);


        LeanTween.scale(optionsButton, Vector3.one * 3.7f, 0.35f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnPointerExit()
    {
        LeanTween.cancel(optionsButton);


        LeanTween.scale(optionsButton, Vector3.one * 3.3f, 0.35f).setEase(LeanTweenType.easeOutQuad);
    }

    public void OnClick()
    {
        optionsMenu.SetActive(true);
        buttons.SetActive(false);
    }

}
