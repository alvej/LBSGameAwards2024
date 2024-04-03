using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTeleportPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private GameState gameState;
    public string sceneName;
    public Transform player;


    void Start()
    {

        gameState = FindObjectOfType<GameState>();

        if(gameState.lastScene == sceneName)
        {
            player.position = transform.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
