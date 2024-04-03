using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    // Start is called before the first frame update

    private GameState gameState;
    private float countdown = 5.0f;
    void Start()
    {

            gameState = GameObject.Find("GameState").GetComponent<GameState>();

    }

    // Update is called once per frame
    void Update()
    {

        

        if (gameState.timeLeft == 0)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                Destroy(gameState.gameObject);
                SceneManager.LoadScene("MainMenu");
            }
        }
        
    }
}
