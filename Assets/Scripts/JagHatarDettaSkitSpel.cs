using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JagHatarDettaSkitSpel : MonoBehaviour
{

    public int speed = 1;
    public GameObject screen;

    private GameState gameState;

    // Start is called before the first frame update
    private void Awake()
    {
        gameState = FindObjectOfType<GameState>();
    }
    void Start()
    {
        StartCoroutine(Exit());
        gameState.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameState);

        screen.transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private IEnumerator Exit()
    {

        yield return new WaitForSeconds(15);

        SceneManager.LoadScene("MainMenu");
    }
}
