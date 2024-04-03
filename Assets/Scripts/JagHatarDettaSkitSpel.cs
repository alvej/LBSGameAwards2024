using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JagHatarDettaSkitSpel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Exit());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Exit()
    {
        yield return new WaitForSeconds(10);

        Application.Quit();
    }
}
