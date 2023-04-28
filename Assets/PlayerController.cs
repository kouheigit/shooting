using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//animation start
public class PlayerController : MonoBehaviour
{
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //GetComponent<AudioSource>().Play();
            transform.Translate(0, 0.2f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.2f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.2f, 0, 0);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //GetComponent<AudioSource>().Play();
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
    /*
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("miya");
    }*/
}

