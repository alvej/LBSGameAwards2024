using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;


    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 input = new Vector2(0, 0);

        if (Input.GetKey(leftKey))
        {
            input.x -= 1;
        }
        if (Input.GetKey(rightKey))
        {
            input.x += 1;
        }
        if (Input.GetKey(upKey))
        {
            input.y += 1;
        }
        if (Input.GetKey(downKey))
        {
            input.y -= 1;
        }

        rigidBody.velocity = input.normalized * speed;
        //Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        
    }
}
