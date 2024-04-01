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
    public bool changeCamera = true;

    public Animator anim;

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

            Debug.Log("hej");

            anim.SetBool("isWalkingLeft", true);
        }
        else
        {
            anim.SetBool("isWalkingLeft", false);
        }
        
        if (Input.GetKey(rightKey))
        {
            input.x += 1;

            anim.SetBool("isWalkingRight", true);
        }
        else
        {
            anim.SetBool("isWalkingRight", false);
        }

        if (Input.GetKey(upKey))
        {
            input.y += 1;

            anim.SetBool("isWalkingFront", true);
        }
        else
        {
            anim.SetBool("isWalkingFront", false);
        }

        if (Input.GetKey(downKey))
        {
            input.y -= 1;

            anim.SetBool("isWalkingBack", true);
        }
        else
        {
            anim.SetBool("isWalkingBack", false);
        }

        rigidBody.velocity = input.normalized * speed;

        if (changeCamera)
        {
            Camera.main.transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
        }
    }
}
