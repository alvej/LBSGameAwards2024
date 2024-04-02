using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningCutscene : MonoBehaviour
{

    public Animator anim;
    void Start()
    {
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

        SceneManager.LoadScene("Corridor");

    }
}
