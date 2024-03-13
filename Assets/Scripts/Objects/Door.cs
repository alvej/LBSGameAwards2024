using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameState gameState;
    private bool changedText = false;
    public string changeTo;

    // Start is called before the first frame update
    void Start()
    {
        gameState = FindObjectOfType<GameState>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Physics2D.OverlapCircle(transform.position, 3.5f, LayerMask.GetMask("Player")))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("FUUDUD");
                SceneManager.LoadScene(changeTo);
                gameState.infoText.text = "";
            }

            if (changedText == false)
            {
                changedText = true;
                gameState.infoText.text = "Press E to open the door";


            }
        }
        else
        {
            if (changedText == true)
            {
                changedText = false;
                gameState.infoText.text = "";
            }
        }

    }
}
