using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathRoomFuckThisFuckingShitICantDoThisAnymore : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite grafittiBathroom;
    public Transform bathroom;

    public Movement movement;

    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.E)) 
        {
            movement.speed = 0;
            StartCoroutine(Spray());

        }
        
    }

    private IEnumerator Spray()
    {
        anim.SetBool("grafitiShake", true);
        yield return new WaitForSeconds(1);
        anim.SetBool("grafitiShake", false);
        anim.SetBool("grafitiSpray", true);
        yield return new WaitForSeconds(1.5f);

        bathroom.GetComponent<SpriteRenderer>().sprite = grafittiBathroom;
        anim.SetBool("grafitiSpray", false);
    }
}

